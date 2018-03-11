using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class car : MonoBehaviour {

	public Button redButton;
	public Button greenButton;
	public Button whiteButton;
	public Button blackButton;
	public Button blueButton;

	// Use this for initialization
	void Start () {
		redButton.onClick.AddListener (PaintRed);
		greenButton.onClick.AddListener (PaintGreen);
		whiteButton.onClick.AddListener (PaintWhite);
		blackButton.onClick.AddListener (PaintBlack);
		blueButton.onClick.AddListener (PaintBlue);
	}

	void PaintRed ()
	{
		Renderer render = GetComponentInChildren<Renderer>();
		render.material.color = Color.red;
	}

	void PaintGreen ()
	{
		Renderer render = GetComponentInChildren<Renderer>();
		render.material.color = Color.green;
	}

	void PaintWhite ()
	{
		Renderer render = GetComponentInChildren<Renderer>();
		render.material.color = Color.white;
	}

	void PaintBlack ()
	{
		Renderer render = GetComponentInChildren<Renderer>();
		render.material.color = Color.black;
	}

	void PaintBlue ()
	{
		Renderer render = GetComponentInChildren<Renderer>();
		render.material.color = Color.blue;
	}

	// Update is called once per frame
	void Update () {
		
	}
}
