using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O_GameManager : MonoBehaviour {

	private int m_Gold;
	public Text m_goldUIText;
	public Text m_nextLifeUIText;
	public Text m_LivesUIText;

	private int nextLife = 200;
	private int m_lives;

	private static O_GameManager m_instance = null;


	void Awake() {
		if (m_instance != null && m_instance != this) {
            Destroy(this.gameObject);
            return;
        } else {
            m_instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
	}

	 void Start () {
        m_lives = 3;
        m_Gold = 0;
    }
	
	// Update is called once per frame
	void Update () {
		m_Gold += 1;
		m_goldUIText.text = (int)Mathf.Floor(m_Gold) + " Gold";
		m_nextLifeUIText.text = " " + (int)Mathf.Floor(nextLife);
		m_LivesUIText.text = " " + (int)Mathf.Floor(m_lives);
		
		if (m_Gold >= nextLife) {
			nextLife = nextLife*2;
			m_lives++;
		}
	}
}
