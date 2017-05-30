using UnityEngine;
using System.Collections;

public class BossPause : MonoBehaviour {

	public GameObject pauseMenu;
	public GameObject player;


	private bool pause;

	void Start () {
		pause = false;
		pauseMenu.SetActive(false);
	}


	void Update () {
		if (Input.GetKeyDown(KeyCode.P)) {
			pause = !pause;
			if (pause) {
				Time.timeScale = 0;
				player.GetComponent<PlayerControl>().enabled = false;
				pauseMenu.SetActive(true);
				GameObject.FindWithTag("MainHUD").GetComponent<Canvas>().enabled = false;
			} else {
				GameObject.FindWithTag("MainHUD").GetComponent<Canvas>().enabled = true;
				Resume();
			}

		}


		//Cursor.visible = true;
	}


	public void NewGame() {
		Time.timeScale = 1;
		Application.LoadLevel(2); // ou Application.LoadLevel(Application.loadedLevel);
	}

	public void Resume() {
		Time.timeScale = 1;
		player.GetComponent<PlayerControl>().enabled = true;
		pauseMenu.SetActive(false);
	}

	public void Credits() {
		Time.timeScale = 1;
		Application.LoadLevel(3);
	}

	public void QuitToMenu() {
		Time.timeScale = 1;
		Application.LoadLevel(1);
	}

	public void Quit() {
		Application.Quit();
	}
}

// Script by Yago Hübner