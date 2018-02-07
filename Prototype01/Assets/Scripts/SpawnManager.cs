using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
	public int ballCount;
	public int maxBall;
	public Spawner[] spawnerObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (ballCount >= maxBall) {
			for (int i=0;i<spawnerObject.Length;i++) {
				spawnerObject[i].allowSpawn = false;
			}
		} else {
			for (int i=0;i<spawnerObject.Length;i++) {
				spawnerObject[i].allowSpawn = true;
			}
		}
	}
}
