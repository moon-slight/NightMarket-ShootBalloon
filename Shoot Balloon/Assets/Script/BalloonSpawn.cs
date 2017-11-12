using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawn : MonoBehaviour {

	public GameObject[] balloonArr;
	private GameObject balloon;

	// Use this for initialization
	void Start () {
		balloon = balloonArr[Random.Range(0, balloonArr.Length)];
		Instantiate (balloon, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
