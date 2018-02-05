using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

	private bool called = false;
	private Rigidbody rigibody;

	// Use this for initialization
	void Start () {
		rigibody = GetComponent<Rigidbody>();
	}

	void OnDispatchHelicopter(){
		
		Debug.Log("Helicopter called");
		rigibody.velocity = new Vector3(0f, 0f, 50f);
		called = true;
	}
}
