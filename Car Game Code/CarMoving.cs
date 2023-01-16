using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoving : MonoBehaviour
{
    //Variables

    public Rigidbody sphere;
   
    
    private float input;
    private float turninput;
    public float forwardspeed;
    public float backspeed;
    public float turnspeed;
    private float cameraAngle;
    private float pitch;
    private float currentspeed;
    private AudioSource engine;
  


    // Start is called before the first frame update
    void Start()
    {
        sphere.transform.parent = null;
        engine=GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Storing the user input keys (either W or S or vertical movements)
        input = Input.GetAxisRaw("Vertical");
        //Storing the user input keys (either A or D or horizontal movements)
        turninput = Input.GetAxisRaw("Horizontal");

        //If the input is positive, multiply input by the forward speed, else multiply it by the backward speed
        if (input>0)
        {
            input *= forwardspeed;
        }
        else
        {
            input *= backspeed;
        }

        //The transform's position is the sphere's position, this will now be used to help adjust the sphere's position    
        transform.position = sphere.transform.position;
        

        //Making a variable to store the rotation value 
        float newRotation=turninput*turnspeed*Time.deltaTime* Input.GetAxisRaw("Vertical");
        
        
        
        //Rotating the sphere object
        transform.Rotate(xAngle:0, yAngle:newRotation,zAngle:0, relativeTo:Space.World);

     

     
       
    }
    private void FixedUpdate()
    {
        //Code that adjusts engine sound according to speed
        currentspeed = sphere.velocity.magnitude*3.3f;
        pitch =  currentspeed / forwardspeed;
        engine.pitch = pitch;
      
        
            
        
        //Adding a force to car vertical movement, if input is 0, this means car does not move
        sphere.AddForce(transform.forward*input,ForceMode.Acceleration);
       
        
        
    }
}


