using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public GameObject player;
	private Vector3 offset = new Vector3(0f, 7.5f, 0f); 

	// Use this for initialization
	void Start () {
		transform.position = player.transform.position + offset;	
	}

	// Update is called once per frame
	void Update () {
		transform.position = player.transform.position + offset;
		transform.rotation = player.transform.rotation;
	}
}
