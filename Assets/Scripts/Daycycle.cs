using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daycycle : MonoBehaviour {

	[Tooltip("Number of minutes per second, try 60")]
	public float minutesPerSecond; 
	
	// Update is called once per frame
	void Update () {

		//Just think about it
		float angleThisFrame = Time.deltaTime / 360 * minutesPerSecond;
		transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);

	}
}
