using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TestScript : MonoBehaviour {

	float time = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		time = time + Time.deltaTime;
		int seconds = (int)time;
		print ("Time: " + seconds);
	}
}
