using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J_Shooting : MonoBehaviour {

	public Rigidbody2D m_shoot; 
	public Transform m_firePoint;
	public Transform m_firePoint2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			ShootLeft();
		}

		if (Input.GetMouseButtonDown(1)) {
			ShootRight();
		}
	}

	void ShootLeft () {
		//Instantiate(m_shoot, m_firePoint.position, Quaternion.identity);
		
		Rigidbody2D cannon = Instantiate(m_shoot, m_firePoint.position, Quaternion.identity) as Rigidbody2D;
		cannon.AddForce(m_firePoint.right * 100);
	}

	void ShootRight () {
		//Instantiate(m_shoot, m_firePoint2.position, Quaternion.identity);

		Rigidbody2D cannon = Instantiate(m_shoot, m_firePoint2.position, Quaternion.identity) as Rigidbody2D;
		cannon.AddForce(-m_firePoint2.right * 100);
	}
}
