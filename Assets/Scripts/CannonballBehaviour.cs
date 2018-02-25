using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballBehaviour : MonoBehaviour {

	public bool isPlayerShooting;
	public int killPoints;
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D other) {
		
		if (isPlayerShooting = true) {
			if (other.gameObject.tag == "Enemy") {
				O_GameManager.AddPoints(killPoints);
				Destroy (other.gameObject);
			}
		}
			
		Destroy (gameObject);
	}
	
}
