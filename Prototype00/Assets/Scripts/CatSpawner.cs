using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour {
	public GameObject[] spawnCat;
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
		if (this.transform.childCount <= 0) {
			Spawn();
		}
		yield return new WaitForSeconds(randomDuration);
	}

	public void Spawn() {
		int randomIndex;
		GameObject spawnObject;
		randomIndex = Random.Range(0,spawnCat.Length);
		spawnObject = (GameObject) Instantiate(spawnCat[randomIndex], new Vector3(0,0,0), this.transform.rotation);
		spawnObject.transform.SetParent(this.transform);
	}
}
