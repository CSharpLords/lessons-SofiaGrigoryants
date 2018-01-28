using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {

	private float max = 0;
	private float min = 1000;

	void Update () {

		if (transform.position.y > max)
		{
			max = transform.position.y;
		}
		if (transform.position.y < min) {
			min = transform.position.y;
		}
		print ("Рекорд высоты: " + max + ", Минимальная высота: " + min);
	}
}