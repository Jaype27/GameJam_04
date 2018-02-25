using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavTest : MonoBehaviour {
	NavMeshAgent m_agent;
	NavMeshHit hit;
	public float range = 10.0f;

	void Awake() {
		m_agent = GetComponent<NavMeshAgent>();
	}


	bool RandomPoint(Vector3 center, float range, out Vector3 result) {
		for (int i = 0; i < 30; i++) {
			Vector3 randomPoint = center + Random.insideUnitSphere * range;
			if (NavMesh.SamplePosition(randomPoint, out hit, 1.0f, NavMesh.AllAreas)) {
				result = hit.position;
				return true;
			}
		}
		result = Vector3.zero;
		return false;
	}
	void Update() {
		if(Input.GetKeyDown(KeyCode.M)){
			Vector3 point;
			if (RandomPoint(transform.position, range, out point)) {
				m_agent.SetDestination(point);
			}

		}
	}
}
