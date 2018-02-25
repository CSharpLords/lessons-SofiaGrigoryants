using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinAge : MonoBehaviour {

	public Text age;
	public static float number = 18;
	// Use this for initialization
	void Start () {
		Button plus = GetComponent<Button> ();
		plus.onClick.AddListener (Increase);
	}

	// Update is called once per frame
	void Increase () {
		number = number - 1;
		age.text = number.ToString();
	}
}
