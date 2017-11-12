using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	public GameObject Front;
	public GameObject Back;
	public int BulletNum;

	private Vector3 shootDirection;

	// Use this for initialization
	void Start () {
		BulletNum = 10;
	}
	
	// Update is called once per frame
	void Update () {
		if (BulletNum >= 1) {
			//raise gun
			if (Input.GetKey (KeyCode.LeftControl)) {
			
			}

			//fire
			if (Input.GetMouseButtonDown(0) && BulletNum >= 1) {
				shootDirection = Front.transform.position - Back.transform.position;
				BulletNum--;
			}

			//choose weapon
			if (Input.GetKey (KeyCode.Space)) {
				shootDirection = Front.transform.position - Back.transform.position;
			}
		}

	}
}
