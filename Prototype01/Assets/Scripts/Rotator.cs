using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	public bool test = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		float randomX;
		float randomY;
		randomX = Random.Range(5f,10f);
		randomY = Random.Range(5f,10f);
		Rigidbody2D otherBody = other.GetComponent<Rigidbody2D>();
		if (other.CompareTag("Ball")) {
			Debug.Log("HALO");
			test = !test;
			otherBody.velocity = new Vector2(randomX,randomY);
		}
	}
}
