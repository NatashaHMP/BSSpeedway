using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbitar : MonoBehaviour {

    [SerializeField]
    private Transform target;
    [SerializeField]
    private Vector3 eixo;
    [SerializeField]
    private float speedRotation;
    [SerializeField]
    private float diamiter;



    private void Update()
    {
        OrbitRotation();
        
    }

    private void OrbitRotation()
    {
        transform.RotateAround(target.position, eixo, speedRotation * Time.deltaTime);
    }
}
