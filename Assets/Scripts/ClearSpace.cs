using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearSpace : MonoBehaviour {

	public float timeSinceLastTrigger = 0f;

	private int objectsInTrigger;
	private bool foundClearArea = false;
	
	// Update is called once per frame
	void Update () {
		
		timeSinceLastTrigger += Time.deltaTime;

		if(objectsInTrigger > 0){
			timeSinceLastTrigger = 0f;
		}

		if(timeSinceLastTrigger >= 1f && !foundClearArea){
			if(Input.GetButtonDown("CallHeli")){
				print("HelliCall request");
				SendMessageUpwards("OnFindClearArea");	//In InnerVoice
				foundClearArea = true;
			}
		}
	}

	void OnTriggerEnter(){
		objectsInTrigger++;
	}

	void OnTriggerExit(){
		objectsInTrigger--;
	}
}
