﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class svetofor2 : MonoBehaviour {
	float time = 0;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		Renderer render = GetComponent<Renderer>();
		time = time + Time.deltaTime;

		if (time > 3)
		{
			time = 0;
			render.material.color = Color.white;
		}
		else if (time > 2)
		{
			render.material.color = Color.red;
		}
	}
}
