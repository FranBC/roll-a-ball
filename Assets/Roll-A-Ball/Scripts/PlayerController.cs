﻿using UnityEngine;
using System;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{

	public float speed = 800.0f;
	public Text scoreText;
	private int count = 0;
	public Text winText;

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider Other){
		if (Other.gameObject.tag == "PickUp") {
			Other.gameObject.SetActive (false);
			count += 1;
			scoreText.text = "Score: " + count;
			if (count >= 17) {
				winText.gameObject.SetActive (true);

			}
		}
	}
}