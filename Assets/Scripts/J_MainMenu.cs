using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class J_MainMenu : MonoBehaviour {

	public string m_LeveltoLoad;
	
	public void PlayGame () {
		SceneManager.LoadScene(m_LeveltoLoad);
	}

	public void Quit () {
		Application.Quit();
	}
}
