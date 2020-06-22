﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float speed = 10.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInput = 100.0f;
    private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        // Player input 
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move the vehicle forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotate the vehicle 
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);


    }
}
