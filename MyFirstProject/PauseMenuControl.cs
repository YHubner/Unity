using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseMenuControl : MonoBehaviour {

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
				player.GetComponent<FirstPersonController>().enabled = false;
				pauseMenu.SetActive(true);
			} else {
				Resume();
			}

		}
	}


	public void NewGame() {
		Time.timeScale = 1;
		Application.LoadLevel(0); // ou Application.LoadLevel(Application.loadedLevel);
	}

	public void Resume() {
		Time.timeScale = 1;
		player.GetComponent<FirstPersonController>().enabled = true;
		pauseMenu.SetActive(false);
	}

	public void Credits() {
		Time.timeScale = 1;
		Application.LoadLevel(2);
	}

	public void Quit() {
		Application.Quit();
	}











}
