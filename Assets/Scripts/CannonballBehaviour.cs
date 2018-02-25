using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballBehaviour : MonoBehaviour {

	public bool isPlayerShooting;
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D other) {
		
		if (other.gameObject.tag == "Enemy") {
		Destroy (other.gameObject);
		}
		
		Destroy (gameObject);
	}
	
}
