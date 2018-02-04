using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {
	float time = 15;
	public Transform enemy;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		time = time - Time.deltaTime;
		if (time < 0)
		{
			Vector3 v = new Vector3(-0.08f, 3.18f, -12.78f);
			transform.position = v;
			time = 15;
		}
		float dist = Vector3.Distance(enemy.position, transform.position);
		//print (dist);
		if (dist < 3) 
		{
			print ("Победа! Секретный предмет найден!!!");
		}
	}
}