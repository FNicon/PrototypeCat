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
		//controller = gameObject.GetComponent<ControllerManager> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}
	public void MoveHorizontal(float horizontalSpeed) {
		playerBody.velocity = new Vector2 (horizontalSpeed * maxSpeed, playerBody.velocity.y);
	}
	public void Shoot() {
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
