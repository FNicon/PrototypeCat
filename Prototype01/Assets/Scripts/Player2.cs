using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {
	private Rigidbody2D playerBody;
	public float maxSpeed;
	// Use this for initialization
	void Start () {
		playerBody = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontalSpeed;
		horizontalSpeed = inputVertical();
		MoveHorizontal(horizontalSpeed);
	}

	public void MoveHorizontal(float horizontalSpeed) {
		playerBody.velocity = new Vector2 (horizontalSpeed * maxSpeed, playerBody.velocity.y);
	}

	float inputVertical() {
		return (Input.GetAxis ("Vertical"));
	}
}
