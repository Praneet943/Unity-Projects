using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoving : MonoBehaviour
{

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
        input = Input.GetAxisRaw("Vertical");
        turninput = Input.GetAxisRaw("Horizontal");


        if (input>0)
        {
            input *= forwardspeed;
        }
        else
        {
            input *= backspeed;
        }

      
        transform.position = sphere.transform.position;
        

        float newRotation=turninput*turnspeed*Time.deltaTime* Input.GetAxisRaw("Vertical");
        
        
        
        
        transform.Rotate(xAngle:0, yAngle:newRotation,zAngle:0, relativeTo:Space.World);

     

     
       
    }
    private void FixedUpdate()
    {

        currentspeed = sphere.velocity.magnitude*3.3f;
        pitch =  currentspeed / forwardspeed;
        engine.pitch = pitch;
      
        
            
        
        
        sphere.AddForce(transform.forward*input,ForceMode.Acceleration);
       
        
        
    }
}


