using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m_ProjectileAI : MonoBehaviour {

	public float speed;

	private Transform player;
	private Vector3 target;

	void Start(){

		player = GameObject.FindGameObjectWithTag("Player").transform;

		target = new Vector3(player.position.x, player.position.y, player.position.z);
	}
	
	void Update(){
	
		transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

		if(transform.position.x == target.x && transform.position.y == target.y){
			DestroyProjectile();
		}
	}

	void OnTriggerEnter (Collider other){
		GameObject Manager = GameObject.Find("GameManager");
		O_GameManager gamemanager = Manager.GetComponent<O_GameManager>();
		if(other.CompareTag("Player")){
			DestroyProjectile();
			O_GameManager.MinusLives(1);
		}
	}

	void DestroyProjectile(){

		Destroy(gameObject);
	}
}
