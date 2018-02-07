using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private Rigidbody2D ballBody;
	public int hurtCount;

	// Use this for initialization
	void Start () {
		ballBody = gameObject.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		//ballBody.AddForce(new Vector2(5f,5f));
		//ballBody.velocity = new Vector2(ballBody.velocity.x,ballBody.velocity.y);
		//body.velocity = new Vector2(body.velocity.x + Mathf.Sin(Time.deltaTime*0.1f)*100,body.velocity.y);
	}

	public void LaunchBall(float launchSpeedX, float launchSpeedY) {
		ballBody = gameObject.GetComponent<Rigidbody2D> ();
		ballBody.velocity = new Vector2(launchSpeedX,launchSpeedY);
	}

	public void DestroyBall() {
		Destroy(this.gameObject);
	}
}
