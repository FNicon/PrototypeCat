using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern : MonoBehaviour {
	public string patternName;
	public Transform thisChild;
	public GameObject enemy;
	public GameObject partner;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.childCount > 0) {
			thisChild = this.transform.GetChild(0);
			patternName = thisChild.gameObject.name;
		}
		if (IsMatch()) {
			enemy.transform.localScale = new Vector3(10,10,10);
		}
	}

	public bool IsMatch() {
		return (partner.GetComponent<Pattern>().patternName == patternName);
	}
}
