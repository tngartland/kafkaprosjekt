using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour {

	public float movementSpeed = 10f;
	// Use this for initialization


	// Update is called once per frame
	void FixedUpdate () {
		
		float moveX = Input.GetAxis ("Horizontal");
		float moveZ = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveX, 0f, moveZ);
		GetComponent<Rigidbody>().velocity = movement * movementSpeed * Time.deltaTime;
			 
	}
}
