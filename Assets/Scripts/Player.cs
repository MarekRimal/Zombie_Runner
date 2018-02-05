using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Transform playerSpawnsHolder;	//Parent of playerSpawns
	private Transform[] playerSpawns;		//Curr spawns
	private bool reSpawn = true;

	public GameObject LandingArea;

	// Use this for initialization
	void Start () {

		playerSpawns = playerSpawnsHolder.GetComponentsInChildren<Transform>();	//This fill the whole array with those child Transforms
																				//But also with the parent Transform so the valid spawns
																				//are at index 1+
	}
	
	// Update is called once per frame
	void Update () {

		if(reSpawn){
			Respawn();
			reSpawn = false;
		}

	}

	private void Respawn(){
		int i = Random.Range(1, playerSpawns.Length);
		transform.position = playerSpawns[i].position;
	}

	void OnFindClearArea(){
		Invoke("DropFlare", 3f);
	}

	void DropFlare(){
		Instantiate(LandingArea, transform.position, transform.rotation);
	}
}
