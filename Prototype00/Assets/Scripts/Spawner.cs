using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject[] spawnThings;
	public float maxDuration;

	public float xMax;

	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnWait());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnWait() {
		float randomDuration;
		randomDuration = Random.Range(0f,maxDuration);
		Spawn();
		yield return new WaitForSeconds(randomDuration);
		StartCoroutine(SpawnWait());
	}

	public void Spawn() {
		int randomIndex;
		float randomX;
		GameObject spawnObject;
		randomIndex = Random.Range(0,spawnThings.Length);
		randomX = Random.Range(-xMax,xMax);
		spawnObject = (GameObject) Instantiate(spawnThings[randomIndex], new Vector3(this.transform.position.x + randomX,this.transform.position.y,0), this.transform.rotation);
	}
}
