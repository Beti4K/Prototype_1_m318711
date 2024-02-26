using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        //move the vehicle forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
