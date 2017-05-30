using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	private bool gameover;

	public GameObject fired;

	public void Start(){

		fired.SetActive (false);

	}

	public void SetGameOver(int i) {

		if (i == 1) gameover = true;


		if (gameover == true) {

			fired.SetActive (true);
			Time.timeScale = 0;

		}
	}

	public void Update(){

		if (Input.GetKeyDown ("return")){

			Time.timeScale = 1;
			fired.SetActive (false);
			Application.LoadLevel (Application.loadedLevel);
		}
	}
}
