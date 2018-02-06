using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private Rigidbody2D playerBody;
	public float maxSpeed;
	// Use this for initialization
	void Start () {
		playerBody = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontalSpeed;
		horizontalSpeed = inputHorizontal();
		MoveHorizontal(horizontalSpeed);
	}

	public void MoveHorizontal(float horizontalSpeed) {
		playerBody.velocity = new Vector2 (horizontalSpeed * maxSpeed, playerBody.velocity.y);
	}

	float inputHorizontal() {
		return (Input.GetAxis ("Horizontal"));
	}
}
