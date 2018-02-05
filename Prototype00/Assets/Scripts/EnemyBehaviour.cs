using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {
	public Rigidbody2D enemyBody;
	public float speed;
	// Use this for initialization
	void Start () {
		enemyBody = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		enemyBody.velocity = new Vector2(enemyBody.velocity.x,speed);
	}
}
