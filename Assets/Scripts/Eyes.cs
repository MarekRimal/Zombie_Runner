using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour {

	private Camera eyes;
	private float defaultFOV; //Field of fiew = how far we see

	// Use this for initialization
	void Start () {
		eyes = GetComponent<Camera>();
		defaultFOV = eyes.fieldOfView;
	}
	
	// Update is called once per frame
	void Update () {

		//Zoom
		if(Input.GetButtonDown("Zoom")){
			eyes.fieldOfView = defaultFOV / 1.5f;
		}
		else if(Input.GetButtonUp("Zoom")){
			eyes.fieldOfView = defaultFOV;
		}
	}
}
