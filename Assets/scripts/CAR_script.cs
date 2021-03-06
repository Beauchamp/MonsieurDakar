﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAR_script : MonoBehaviour {


public float maxTorque = 500f;
public float maxSteerAngle = 45f;
public WheelCollider[] wheelCollider = new WheelCollider[6];
public Transform[] wheelMesh = new Transform[6];
private Rigidbody r_Ridgedbody;
public Transform t_CenterOfMass;

    public void Start()
{

    r_Ridgedbody = GetComponent<Rigidbody>();
    r_Ridgedbody.centerOfMass = t_CenterOfMass.localPosition;

        for (int i = 0; i < 6; i++)
    {
        wheelCollider[i].ConfigureVehicleSubsteps(15, 12, 30);

    }

}

    /*
public void UpdateMeshPosition()
{
    for (int i = 0; i < 4; i++)
    {
        Quaternion quat;
        Vector3 pos;

        wheelCollider[i].GetWorldPose(out pos, out quat);
        wheelMesh[i].position = pos;
        wheelMesh[i].rotation = quat;
    
    }
}

    */

// Update every fixed framerate frame, use this when dealing with Rigidbody
public void FixedUpdate()
{

    //UpdateMeshPosition();

    float steer = Input.GetAxis("Horizontal") * maxSteerAngle;
    float torque = Input.GetAxis("Vertical") * maxTorque;

    wheelCollider[0].steerAngle = steer;
    wheelCollider[1].steerAngle = steer;

    for (int i = 0; i < 2; i++)
    {
        wheelCollider[i].motorTorque = torque;
    }



}
}
