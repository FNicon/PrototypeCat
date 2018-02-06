using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	private Rigidbody2D playerBody;
	public float maxSpeed;
	public Transform shootCollider;
	public float shootSpeed;
	public float cooldownTime;
	private bool allowShoot = true;
	// Use this for initialization
	void Start () {
		playerBody = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontalSpeed;
		//horizontalSpeed = inputHorizontal();
		horizontalSpeed = inputTouchHorizontal();
		MoveHorizontal(horizontalSpeed);
		if (inputTouchShoot()) {
			Shoot();
		}
	}

	public void MoveHorizontal(float horizontalSpeed) {
		playerBody.velocity = new Vector2 (horizontalSpeed * maxSpeed, playerBody.velocity.y);
	}

	float inputHorizontal() {
		return (Input.GetAxis ("Horizontal"));
	}
	float inputTouchHorizontal() {
		if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Moved)) {
			return(Input.GetTouch(0).deltaPosition.x);
		} else {
			return (0f);
		}
	}
	bool inputTouchShoot() {
		if ((Input.touchCount > 1) && (Input.GetTouch(1).phase == TouchPhase.Began)) {
			return (true);
		} else {
			return (false);
		}
	}
	void Shoot() {
		if (allowShoot) {
			allowShoot = false;
			shootCollider.localScale = new Vector2(shootCollider.localScale.x*shootSpeed,shootCollider.localScale.y*shootSpeed);
			StartCoroutine(Cooldown());
		}
	}
	IEnumerator Cooldown() {
		yield return new WaitForSeconds(cooldownTime);
		shootCollider.localScale = new Vector2(1f,1f);
		allowShoot = true;
	}
}
