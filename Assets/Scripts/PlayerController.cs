using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    void Start()
    {
        
    }

    void Update()
    {
        //move the vehicle forward
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
    }
}
