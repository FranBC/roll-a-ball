﻿using UnityEngine;
using System;

[RequireComponent (typeof (Rigidbody))]
public class AccelerometerMoving : MonoBehaviour {
	float speed = 10F;
	Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		Vector3 acc = Input.acceleration;
		rb.AddForce(acc.x * speed, 0, acc.y * speed);
	}
}