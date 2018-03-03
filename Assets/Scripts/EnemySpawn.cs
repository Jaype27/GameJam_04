using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {
	public GameObject enemy;
	public Transform enemyPos;
	public int enemyCount = 0;
	private float repeatRate = 2.0f;

	void Start () {

	}

	void Update () {
		
		GameObject Manager = GameObject.Find("GameManager");
		O_GameManager gamemanager = Manager.GetComponent<O_GameManager>();
		
		enemyCount = gamemanager.spawnCount;
	}
	
	void OnTriggerStay (Collider other) 
	{
		if (other.gameObject.tag == "Player")
		{ 
			InvokeRepeating("EnemySpawner", 0.5f, repeatRate);
			gameObject.GetComponent<BoxCollider>().enabled = false;

		}
		
	}

	void EnemySpawner()
	{
		if(enemyCount>=5) {
			} else {
				Instantiate(enemy, enemyPos.position, enemyPos.rotation);
				enemyCount++;
			}
		
	}
}
