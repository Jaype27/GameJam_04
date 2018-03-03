using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class O_GameManager : MonoBehaviour {

	public static int m_Gold;
	public static int m_lives;
	public Text m_goldUIText;
	public Text m_nextLifeUIText;
	public Text m_LivesUIText;


	private int nextLife = 200;

	public int spawnCount = 0;
	public string m_LeveltoLoad;

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
		m_goldUIText.text = (int)Mathf.Floor(m_Gold) + " Gold";
		m_nextLifeUIText.text = " " + (int)Mathf.Floor(nextLife);
		m_LivesUIText.text = " " + (int)Mathf.Floor(m_lives);
		
		if (m_Gold >= nextLife) {
			nextLife = nextLife*2;
			m_lives++;
		}

		if(m_lives <= 0){
			SceneManager.LoadScene(m_LeveltoLoad);
		}

	}

	void OnCollisonEnter(Collider other) {
		Debug.Log("Just Touched: " + other.name);

		if (other.gameObject.tag == "Cannon" || other.gameObject.tag == "Enemy"){
			Destroy(other.gameObject);
		} else {
			
		}
	}


	public static void AddPoints(int pointsToAdd) {
		m_Gold += pointsToAdd;
	}

	public static void MinusLives(int takeAway) {
		m_lives -= takeAway;
	}



}
