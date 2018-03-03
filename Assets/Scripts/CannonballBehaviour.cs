using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballBehaviour : MonoBehaviour {

	public bool isPlayerShooting;
	public int killPoints;
	
	
	
	// Use this for initialization
	void Start () {
		killPoints = 100;
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (this.gameObject, 1f);
	}

	void OnTriggerEnter (Collider other) {

		GameObject Manager = GameObject.Find("GameManager");
		O_GameManager gamemanager = Manager.GetComponent<O_GameManager>();

			if (other.gameObject.tag == "Enemy") {
				O_GameManager.AddPoints(killPoints);
				Destroy (other.gameObject);
				Destroy (this.gameObject);
				gamemanager.spawnCount--;
			}
	}
	
}
