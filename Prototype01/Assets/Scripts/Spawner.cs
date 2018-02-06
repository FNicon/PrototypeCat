using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	public GameObject[] spawnThings;
	public float maxDuration;

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
		GameObject spawnObject;
		randomIndex = Random.Range(0,spawnThings.Length);
		spawnObject = (GameObject) Instantiate(spawnThings[randomIndex], new Vector2(this.transform.position.x,this.transform.position.y), this.transform.rotation);
	}
}
