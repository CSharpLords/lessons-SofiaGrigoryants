using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {
	float time = 0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		time = time + Time.deltaTime;
		if (time > 15) {
			transform.position = new Vector3(-4.990835f, 0.98f, 10.04f);
			time = 0;
		}
	}
}
