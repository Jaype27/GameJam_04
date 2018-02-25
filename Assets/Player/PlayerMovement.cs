using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
private Vector3  pos = Vector3.zero;
public float m_speed = 5.0f;
public Rigidbody m_rb;
public float m_rotate = 1.0f;

	void Awake() {
			m_rb = GetComponent<Rigidbody>();
	}


	void Update() {
		pos = gameObject.transform.position;
		pos = gameObject.transform.rotation;
					
		if (Input.GetAxis("Vertical") != 0) {
			pos.y += Input.GetAxis("Vertical") * m_speed;
		}

		if (Input.GetAxis("Horizontal") != 0) {
			pos.x += Input.GetAxis("Horizontal") * m_rotate;
		}
		gameObject.transform.position = pos;
		gameObject.transform.rotation = pos;
	}	
}
