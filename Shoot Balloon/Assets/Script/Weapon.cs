using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	public GameObject Front;
	public GameObject Back;
	public GameObject[] weapons;
	public Transform BulletSpawn;
	public int BulletNum;
	public int score;

	private Vector3 shootDirection;

	// Use this for initialization
	void Start () {
		BulletNum = 10;
		score = 0;
		weapons = new GameObject[6];
	}
	
	// Update is called once per frame
	void Update () {
		if (BulletNum >= 1) {
			//raise gun
			if (Input.GetKey (KeyCode.LeftControl)) {
			
			}

			//fire
			if (Input.GetMouseButtonDown(0)) {

				RaycastHit Hit;
				shootDirection = Front.transform.position - Back.transform.position;
				Ray ShootRay = new Ray (BulletSpawn.position, Vector3.Normalize(shootDirection));

				if (Physics.Raycast (ShootRay, out Hit, 500f)) {
					BalloonSpawn B = Hit.transform.GetComponent<BalloonSpawn> ();

					if (B != null) {
						if (Hit.collider.name == "BalloonBlue" || Hit.collider.name == "BalloonGreen" || Hit.collider.name == "BalloonRed"
						   || Hit.collider.name == "BalloonYellow") {
							Destroy (B.gameObject);
							score++;
						}
					}
				}
				BulletNum--;
			}

			//choose weapon
			if (Input.GetKey (KeyCode.Space)) {
				
				RaycastHit Hit;
				shootDirection = Front.transform.position - Back.transform.position;
				Ray ShootRay = new Ray (BulletSpawn.position, Vector3.Normalize(shootDirection));

				if (Physics.Raycast (ShootRay, out Hit, 300f)) {
					if (Hit.collider.name == "Ak-47" || Hit.collider.name == "Ak-47 (1)") {
						for (int i = 0; i < 6; i++)
							weapons [i].SetActive (false); 
						weapons [0].SetActive (true);
					}

					else if (Hit.collider.name == "PM-40_Variant2" || Hit.collider.name == "PM-40_Variant2 (1)") {
						for (int i = 0; i < 6; i++)
							weapons [i].SetActive (false); 
						weapons [1].SetActive (true);
					}

					else if (Hit.collider.name == "PM-40_Variant4" || Hit.collider.name == "PM-40_Variant4 (1)") {
						for (int i = 0; i < 6; i++)
							weapons [i].SetActive (false); 
						weapons [2].SetActive (true);
					}

					else if (Hit.collider.name == "M4A1 Sopmod" || Hit.collider.name == "M4A1 Sopmod (1)") {
						for (int i = 0; i < 6; i++)
							weapons [i].SetActive (false); 
						weapons [3].SetActive (true);
					}

					else if (Hit.collider.name == "Skorpion VZ" || Hit.collider.name == "Skorpion VZ (1)") {
						for (int i = 0; i < 6; i++)
							weapons [i].SetActive (false); 
						weapons [4].SetActive (true);
					}

					else if (Hit.collider.name == "UMP-45" || Hit.collider.name == "UMP-45 (1)" || Hit.collider.name == "UMP-45 (2)") {
						for (int i = 0; i < 6; i++)
							weapons [i].SetActive (false); 
						weapons [5].SetActive (true);
					}
				}
			}
		}

	}
}
