using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WC
{
    public WheelCollider wheelFL;
    public WheelCollider wheelFR;
    public WheelCollider wheelRL;
    public WheelCollider wheelRR;
}
[System.Serializable]
public class WT
{
    public Transform wheelFL;
    public Transform wheelFR;
    public Transform wheelRL;
    public Transform wheelRR;
}

[RequireComponent(typeof(Rigidbody))]
public class MoveCar : MonoBehaviour {

    //MOBILE 
    public GameObject MoveFront
    {
        get { return moveFront; }
        set { moveFront = value; }
    }
    [SerializeField]
    private GameObject moveFront;

    public GameObject MoveBack
    {
        get { return moveBack; }
        set { moveBack = value; }
    }
    [SerializeField]
    private GameObject moveBack;

    public GameObject ButtonDir
    {
        get { return ButtonDir; }
        set { ButtonDir = value; }
    }
    [SerializeField]
    private GameObject buttonDir;

    public GameObject ButtonEsq
    {
        get { return ButtonEsq; }
        set { ButtonEsq = value; }
    }
    [SerializeField]
    private GameObject buttonEsq;

    private ButtonConstantPress componentFront;
    private ButtonConstantPress componentBack;
    private ButtonConstantPress componentDir;
    private ButtonConstantPress componentEsq;
    private float verticalInput;
    private float horizontalInput;





    [SerializeField]
    private WC wheels;
    [SerializeField]
    private WT tires;
    [SerializeField]
    private Vector3 centerOfGravity;
    [SerializeField]
    private float maxTorque = 1000f;
    [SerializeField]
    private float maxReverseSpeed = 50f;
    [SerializeField]
    private float maxSteer = 25f;
    private bool reversing;
    private float currentSpeed;
    [SerializeField]
    private float maxSpeed = 150f;
    private Vector3 localCurrentSpeed;


    private void Start()
    {
        LoadResources();
    }

    private void LoadResources()
    {
        GetComponent<Rigidbody>().centerOfMass = centerOfGravity;
        componentFront = moveFront.GetComponent<ButtonConstantPress>();
        componentBack = moveBack.GetComponent<ButtonConstantPress>();
        componentDir = buttonDir.GetComponent<ButtonConstantPress>();
        componentEsq = buttonEsq.GetComponent<ButtonConstantPress>();
    }


    private void FixedUpdate()
    {
        SetCenterOfGravity();
        AllignWheels();
        Drive();
        SetCurrentSpeed();
    }

    private void SetCenterOfGravity()
    {
        if (GetComponent<Rigidbody>().centerOfMass != centerOfGravity)
            GetComponent<Rigidbody>().centerOfMass = centerOfGravity;
    }

    private void SetCurrentSpeed()
    {
        currentSpeed = GetComponent<Rigidbody>().velocity.magnitude * 2.23693629f;//convert currentspeed into MPH
        localCurrentSpeed = transform.InverseTransformDirection(GetComponent<Rigidbody>().velocity);
    }

    private void AllignWheels()
    {
        Quaternion quat;
        Vector3 pos;
        wheels.wheelFL.GetWorldPose(out pos, out quat);
        tires.wheelFL.position = pos;
        tires.wheelFL.rotation = quat;

        wheels.wheelFR.GetWorldPose(out pos, out quat);
        tires.wheelFR.position = pos;
        tires.wheelFR.rotation = quat;

        wheels.wheelRL.GetWorldPose(out pos, out quat);
        tires.wheelRL.position = pos;
        tires.wheelRL.rotation = quat;

        wheels.wheelRR.GetWorldPose(out pos, out quat);
        tires.wheelRR.position = pos;
        tires.wheelRR.rotation = quat;
    }

    private void Drive()
    {
            float gasMultiplier = 0f;
        if (!reversing)
        {
            if (currentSpeed < maxSpeed)
                gasMultiplier = 1f;
            else
                gasMultiplier = 0f;
        }
        else
        {
            if (currentSpeed < maxReverseSpeed)
                gasMultiplier = 1f;
            else
                gasMultiplier = 0f;
        }
        wheels.wheelRR.motorTorque = maxTorque * (Input.GetAxis("Vertical") + VerticalMobileInput()) * gasMultiplier;
        wheels.wheelRL.motorTorque = maxTorque * (Input.GetAxis("Vertical") + VerticalMobileInput()) * gasMultiplier;

        if (localCurrentSpeed.z < -0.1f && wheels.wheelRL.rpm < 10)
        {
            reversing = true;
        }
        else
        {
            reversing = false;
        }
        wheels.wheelFL.steerAngle = maxSteer * (Input.GetAxis("Horizontal") + HorizontalMobileInput());
        wheels.wheelFR.steerAngle = maxSteer * (Input.GetAxis("Horizontal") + HorizontalMobileInput());
    }

    private float VerticalMobileInput()
    {
        if (componentFront.Input == 1)
        {
            verticalInput = 1;
        }
        else if (componentBack.Input == 1)
        {
            verticalInput = -1;
        }
        else
        {
            verticalInput = 0;
        }
        return verticalInput;
    }

    private float HorizontalMobileInput()
    {
        if (componentDir.Input == 1)
        {
            horizontalInput = 1;
        }
        else if (componentEsq.Input == 1)
        {
            horizontalInput = -1;
        }
        else
        {
            horizontalInput = 0;
        }
        return horizontalInput;
    }

    //"MPH: " + Mathf.Round(GetComponent<Rigidbody>().velocity.magnitude * 2.23693629f))   velocidade do carro

}
