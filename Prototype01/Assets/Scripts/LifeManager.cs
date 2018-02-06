using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour {
	public int fullHealth;
	public Text healthViewer;
	private int currentHealth;
	private bool isAlive;
	// Use this for initialization
	void Start () {
		isAlive = true;
		currentHealth = fullHealth;
		healthViewer.text = currentHealth.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void Hurt() {
		if (isAlive) {
			currentHealth = currentHealth - 1;
			healthViewer.text = currentHealth.ToString();
		}
		if (currentHealth <= 0) {
			Dead();
		}
	}

	public void Dead() {
		isAlive = false;
		healthViewer.text = "Dead!";
	}
}
