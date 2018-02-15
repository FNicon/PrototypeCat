using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerManager : MonoBehaviour {
	public Player player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontalSpeed;
		horizontalSpeed = inputHorizontal();
		//horizontalSpeed = inputTouchHorizontal();
		player.MoveHorizontal(horizontalSpeed);
		if (inputTouchShoot()) {
			player.Shoot();
		}
	}
	public float inputHorizontal() {
		Debug.Log(Input.GetAxis("Horizontal").ToString());
		return (Input.GetAxis ("Horizontal"));
	}
	public float inputTouchHorizontal() {
		if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Moved)) {
			return(Input.GetTouch(0).deltaPosition.x);
		} else {
			return (0f);
		}
	}
	public bool inputTouchShoot() {
		if ((Input.touchCount > 1) && (Input.GetTouch(1).phase == TouchPhase.Began)) {
			return (true);
		} else {
			return (false);
		}
	}
}
