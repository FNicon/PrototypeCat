﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject[] spawnThings;
	public float maxDuration;
	public float minDuration;
	public Vector2 launchAim;
	public float launchSpeed;
	public float minimumLaunchSpeed;
	public bool allowSpawn = false;
	public SpawnManager managerSpawn;

	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnWait());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnWait() {
		float randomDuration;
		randomDuration = Random.Range(minDuration,maxDuration);
		if (allowSpawn) {
			Spawn();
		}
		yield return new WaitForSeconds(randomDuration);
		StartCoroutine(SpawnWait());
	}

	public void Spawn() {
		managerSpawn.ballCount = managerSpawn.ballCount + 1;
		int randomIndex;
		GameObject spawnObject;
		randomIndex = Random.Range(0,spawnThings.Length);
		spawnObject = (GameObject) Instantiate(spawnThings[randomIndex], new Vector2(this.transform.position.x,this.transform.position.y), this.transform.rotation);
		
		float launchRandomizer;
		launchRandomizer = Random.Range(minimumLaunchSpeed,launchSpeed);
		spawnObject.GetComponent<Ball>().LaunchBall(launchAim.x * launchRandomizer,launchAim.y * launchRandomizer);
	}
}
