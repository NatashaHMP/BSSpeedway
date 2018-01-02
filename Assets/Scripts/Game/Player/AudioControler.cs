using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControler : MonoBehaviour
{

    [SerializeField]
    private AudioSource som;
    private const float acceleration = 0.001f;
    private const float desacceleration = 0.01f;
    private const float MAX_PITCH = 3f;
    private const float MIN_PITCH = 1f;

    [SerializeField]
    private AudioSource starSound;

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


    private ButtonConstantPress componentFront;
    private ButtonConstantPress componentBack;

    private void Start()
    {
        LoadResources();
    }

    private void LoadResources()
    {
        componentFront = moveFront.GetComponent<ButtonConstantPress>();
        componentBack = moveBack.GetComponent<ButtonConstantPress>();
    }



    private void Update()
    {
        MotorSound();
        StopSong();
    }

    private void MotorSound()
    {
        if ((Input.GetAxisRaw("Vertical") != 0 || componentFront.Input == 1 || componentBack.Input == 1) && som.pitch < MAX_PITCH)
        {
            som.pitch = som.pitch + acceleration;
        }
        else if (som.pitch > MIN_PITCH)
        {
            som.pitch = som.pitch - desacceleration;
        }
    }


    private void StopSong()
    {
        if (Time.timeScale == 0.0f)
        {
            som.Stop();
        }
    }


    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == Constants.TagName.STAR)
        {
            starSound.Play();
        }
    }
}
