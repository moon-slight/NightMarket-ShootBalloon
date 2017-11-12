using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class system : MonoBehaviour {

	public GameObject Player;
	public Canvas Result;
	public Image Present;
	public Text Score;
	public Text Bullet;

	private Weapon weaponscript;
	private int BulletCount;
	private int score;

	// Use this for initialization
	void Start () {
		Result.enabled = false;
		weaponscript = Player.GetComponent<Weapon>();
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		BulletCount = weaponscript.BulletNum;	
		Score.text = score.ToString();
		Bullet.text = BulletCount.ToString();

		if (BulletCount == 0)
			Result.enabled = true;

	}

	public void Again()
	{
		SceneManager.LoadScene ("GameScreen", LoadSceneMode.Single);
	}

	public void Exit()
	{
		Application.Quit ();
	}
}
