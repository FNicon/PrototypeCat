using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroyer : MonoBehaviour {
	public LifeManager lifeUpdater;
	public SpawnManager managerSpawn;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Ball")) {
			Ball ballScript;
			ballScript = other.GetComponent<Ball> ();
			if (ballScript.hurtCount == 1) {
				managerSpawn.ballCount = managerSpawn.ballCount - 1;
				ballScript.hurtCount = 0;
				lifeUpdater.Hurt();
			}
			ballScript.DestroyBall();
			//Destroy(other.gameObject);
		}
	}
}
