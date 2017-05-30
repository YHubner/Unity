using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOver : MonoBehaviour {

	private int sign;
	private float timer;

	void Start () {

		timer = 5;
		sign = -1;
	}

	void Update () {


		timer = timer += sign * Time.deltaTime;

		if (timer <= 0) {
	
		SceneManager.LoadScene(0);

		}
	}
}
