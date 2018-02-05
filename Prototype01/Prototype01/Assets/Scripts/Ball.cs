using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public Rigidbody2D body;
	public float randomSpeed;
	public float minimalSpeed;

	// Use this for initialization
	void Start () {
		float randomX;
		float randomY;
		randomX = Random.Range(minimalSpeed,randomSpeed);
		randomY = Random.Range(minimalSpeed,randomSpeed);

		body = gameObject.GetComponent<Rigidbody2D>();
		body.velocity = new Vector2(randomX,randomY);
	}
	
	// Update is called once per frame
	void Update () {
		body.velocity = new Vector2(body.velocity.x + Mathf.Sin(Time.deltaTime*0.1f)*100,body.velocity.y);
	}
}
