using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncrAge : MonoBehaviour {

	public Text age;
	// Use this for initialization
	void Start () {
		Button plus = GetComponent<Button> ();
		plus.onClick.AddListener (Increase);
	}

	// Update is called once per frame
	void Increase () {
		MinAge.number = MinAge.number + 1;
		age.text = MinAge.number.ToString();
	}
}
