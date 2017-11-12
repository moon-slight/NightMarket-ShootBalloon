using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject camera;

	private Weapon weaponscript;
	private int BulletCount;
	private int MoveSpeed;
	private int RotateSpeed;

	// Use this for initialization
	void Start () {
		weaponscript = this.GetComponent<Weapon> ();
		MoveSpeed = 20;
		RotateSpeed = 8;
	}
	
	// Update is called once per frame
	void Update () {

		BulletCount = weaponscript.BulletNum;
		if (BulletCount != 0) {

			//movement
			if (Input.GetKey ("w"))
				transform.Translate (Vector3.forward * MoveSpeed * Time.deltaTime);
			if (Input.GetKey ("s"))
				transform.Translate (Vector3.back * MoveSpeed * Time.deltaTime);
			if (Input.GetKey ("a"))
				transform.Translate (Vector3.left * MoveSpeed * Time.deltaTime);
			if (Input.GetKey ("d"))
				transform.Translate (Vector3.right * MoveSpeed * Time.deltaTime);

			//perspective rotation
			camera.transform.Rotate (Input.GetAxis ("Mouse Y") * Time.deltaTime * -RotateSpeed, Input.GetAxis ("Mouse X") * Time.deltaTime * RotateSpeed, 0);

			//fix player rotation
			transform.rotation = Quaternion.Euler (0, 0, 0);
		}

	}
}