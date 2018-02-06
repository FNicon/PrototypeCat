using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private Rigidbody2D ballBody;
	public float maximumSpeed;
	public float minimumSpeed;
	public int hurtCount;

	// Use this for initialization
	void Start () {
		float randomSpeedX;
		float randomSpeedY;
		randomSpeedX = Random.Range(minimumSpeed,maximumSpeed);
		randomSpeedY = Random.Range(minimumSpeed,maximumSpeed);

		ballBody = gameObject.GetComponent<Rigidbody2D> ();
		ballBody.velocity = new Vector2(randomSpeedX,randomSpeedY);
	}
	
	// Update is called once per frame
	void Update () {
		//body.velocity = new Vector2(body.velocity.x + Mathf.Sin(Time.deltaTime*0.1f)*100,body.velocity.y);
	}
}
