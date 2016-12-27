using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelturnleft : MonoBehaviour {

    public Rigidbody wheel;

    // Use this for initialization
    void Start ()
    {

        wheel = this.GetComponent<Rigidbody>();
        wheel.maxAngularVelocity = 1500;

    }
	
	// Update is called once per frame
	public void FixedUpdate ()
    {
        if (Input.GetKey("left")==true)
        {


            //print("prdel");
            wheel.AddForceAtPosition(Vector3.back * 10000 * Time.deltaTime, transform.position);



        }

    }
}
