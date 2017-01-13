using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour {

	GameManager gameMangeer;
	// Use this for initialization
	void Start () {

	//	gameMangeer = GameObject.Find ("GameManager").GetComponent<GameManager> ();
	//	gameMangeer.coins++;
	}
	
	// Update is called once per frame
	void Update () {
	//	transform.Rotate (Vector3.left);	
	}

	void OnCollisionEnter(Collision other)
	{
	//	if (other.gameObject.tag == "Player") {
	//		Destroy (gameObject);
	//		gameMangeer.coins--;
	//	}
	}

}
