using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	public Text scoreText;
	public int life;
	// Use this for initialization
	void Start () {
		scoreText.text = life.ToString();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void LifeDown() {
		life = life - 1;
		scoreText.text = life.ToString();
	}
}
