using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelturnright : MonoBehaviour {

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
        if (Input.GetKey("right")==true)
        {

            //print("prdel");
            //wheel.AddRelativeTorque(transform.left*350);
            //ForceMode Acceleration = default(ForceMode);
            //print("prdel");
            //wheel.AddRelativeTorque(transform.left*350*Time.deltaTime);
            //wheel.AddRelativeTorque(0, 100000, 0, Acceleration);

            

            wheel.AddForceAtPosition(Vector3.back * 10000*Time.deltaTime, transform.position);
            print(wheel.angularVelocity);
        }

    }
}
