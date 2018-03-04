using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public Button startButton;
	public Button creditsButton;
	public Button exitButton;

	// Use this for initialization
	void Start () {
		startButton.onClick.AddListener (LoadGame);
		exitButton.onClick.AddListener (ExitGame);
	}

	void LoadGame() {
		SceneManager.LoadScene("Football");
	}
		
	void ExitGame() {
		Application.Quit();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
