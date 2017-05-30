using UnityEngine;
using System.Collections;

public class PlayerDeath : MonoBehaviour {

	public Animator EndGame;
	public GameObject GameOver;
	public GameObject player;

	void Start () {
	
		GameOver.SetActive (false);

	}

	void Update () {

	}
	

	void OnCollisionEnter(Collision hit) {

		if (hit.gameObject.tag == "enemybullet")
		{
			GameOver.SetActive(true);
			GameObject.FindWithTag("Piramide").GetComponent<PhotoAreaFinal>().enabled = false;
			GameObject.FindWithTag("Player").GetComponent<TakePicture>().enabled = false;
			Time.timeScale = 0;
		}
	}

	void OnTriggerEnter(Collider hit) {

		if (hit.gameObject.tag == "enemybullet")
		{
			GameOver.SetActive(true);
			GameObject.FindWithTag("Piramide").GetComponent<PhotoAreaFinal>().enabled = false;
			GameObject.FindWithTag("Player").GetComponent<TakePictureFinal>().enabled = false;
			Time.timeScale = 0;
		}
	}
}

// Script by Yago Hübner