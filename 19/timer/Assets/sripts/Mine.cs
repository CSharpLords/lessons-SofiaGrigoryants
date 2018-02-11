using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour {
	public Transform player;
	// Use this for initialization
	void Start () {
		print (player.position.x);
	}
	
	// Update is called once per frame
	void Update () {
		float dist = Vector3.Distance(player.position, transform.position);
		print (dist);
		if (dist < 2) {
			player.position = new Vector3(-4.990835f, 0.98f, 10.04f);
		}
	}
}
