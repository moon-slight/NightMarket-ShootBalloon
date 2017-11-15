using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	public GameObject Front;
	public GameObject Back;
	public GameObject BulletPrefab;
	public Transform BulletSpawn;
	public int BulletNum;
	public int score;

	private Vector3 shootDirection;

	// Use this for initialization
	void Start () {
		BulletNum = 10;
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (BulletNum >= 1) {
			//raise gun
			if (Input.GetKey (KeyCode.LeftControl)) {
			
			}

			//fire
			if (Input.GetMouseButtonDown(0) && BulletNum >= 1) {

				RaycastHit Hit;
				shootDirection = Front.transform.position - Back.transform.position;
				var bullet = (GameObject)Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);
				bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;
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
				shootDirection = Front.transform.position - Back.transform.position;
			}
		}

	}
}
