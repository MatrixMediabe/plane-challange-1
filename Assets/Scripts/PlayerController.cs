using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //assign private variables 
    private float speed = 15.0f;
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //assign player input values to the current varialbles
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        //Move the tank back-to-front
        transform.Translate(Vector3.forward * Time.deltaTime * speed* forwardInput);
        
        //Move the tank left-to-right
        transform.Rotate(Vector3.up ,turnSpeed * horizontalInput * Time.deltaTime);
    
    
    }
}
