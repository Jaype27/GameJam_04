using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

public float m_rotateSpeed = 10.0f; 
public float m_moveSpeed = 10.0f;
private Rigidbody2D m_rb;
int test;
	
	void Awake () {
		m_rb = GetComponent<Rigidbody2D>(); 
	}

	void Update () {
		if (Input.GetAxis("Vertical") != 0) {
			m_rb.velocity = Input.GetAxis("Vertical") * transform.up * -m_moveSpeed;
		}

		if (Input.GetAxis("Horizontal") != 0) {
			transform.Rotate(0, 0, -m_rotateSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
		}
	}
}