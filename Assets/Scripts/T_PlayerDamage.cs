using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_PlayerDamage : MonoBehaviour {

	public int playerHealth = 1 ;
	int damage = 1;


	// Use this for initialization
	void Start () {
		print(playerHealth);
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter(Collision m_collision) {
		if(m_collision.gameObject.tag == "tag") {
			playerHealth -= damage;
			print(playerHealth);
		}
		
	}
}
