using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        //move the vehicle forward
        transform.Translate(0, 0, 1);
    }
}
