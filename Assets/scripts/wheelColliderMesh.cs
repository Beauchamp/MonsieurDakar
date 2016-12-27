using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelColliderMesh : MonoBehaviour {

	public WheelCollider Wheel;
	Vector3 BaseEulers = Vector3.one;
	Vector3 BaseTangent = Vector3.one;
	float rotation_; 

	void Start(){
		if (BaseEulers == Vector3.one) {
			BaseEulers = transform.localEulerAngles;
			BaseTangent = new Vector3 (BaseEulers.x, BaseEulers.y, BaseEulers.z);
		}
	}

	void Update () {
		rotation_ += Wheel.rpm / 60 * 360 * Time.deltaTime;
		transform.localEulerAngles = new Vector3(-rotation_, Wheel.steerAngle, 0) + BaseEulers;
	}
}
