using UnityEngine;
using System.Collections;

public class PauseMenuControl : MonoBehaviour {

	public GameObject pauseMenu;
	public GameObject player;
	public AudioClip ping;
	public AudioClip ping2;
	public AudioClip pingbutton;
	public AudioClip soundmenu;
	public AudioSource source;



	private bool pause;

	void Start () {
		pause = false;
		pauseMenu.SetActive(false);
	}


	void Update () {
		if (Input.GetKeyDown(KeyCode.P)) {
			pause = !pause;
			if (pause) {
				source.PlayOneShot (soundmenu);
				source.PlayOneShot (ping);
				Time.timeScale = 0;
				player.GetComponent<PlayerControl>().enabled = false;
				pauseMenu.SetActive(true);
				GameObject.FindWithTag("MainHUD").GetComponent<Canvas>().enabled = false;
				GameObject.FindWithTag("Hints").GetComponent<ControlsTutorial>().enabled = false;
				//GameObject.FindWithTag ("SoundControl").GetComponent<AudioSource> ().Pause();
				GameObject.FindWithTag ("SoundControl").GetComponent<AudioSource> ().enabled = false;
			} else {
				source.Stop ();
				source.PlayOneShot (ping2);
				GameObject.FindWithTag("MainHUD").GetComponent<Canvas>().enabled = true;
				GameObject.FindWithTag("Hints").GetComponent<ControlsTutorial>().enabled = true;
				//GameObject.FindWithTag ("SoundControl").GetComponent<AudioSource> ().UnPause();
				GameObject.FindWithTag ("SoundControl").GetComponent<AudioSource> ().enabled = true;
				Resume();
			}

		}

	
		//Cursor.visible = true;
	}


	public void NewGame() {
		Time.timeScale = 1;
		source.PlayOneShot (pingbutton);
		Application.LoadLevel(2); // ou Application.LoadLevel(Application.loadedLevel);
	}

	public void Resume() {
		Time.timeScale = 1;
		source.PlayOneShot (pingbutton);
		player.GetComponent<PlayerControl>().enabled = true;
		pauseMenu.SetActive(false);
	}

	public void Credits() {
		Time.timeScale = 1;
		source.PlayOneShot (pingbutton);
		Application.LoadLevel(3);
	}

	public void QuitToMenu() {
		Time.timeScale = 1;
		source.PlayOneShot (pingbutton);
		Application.LoadLevel(1);
	}

	public void Quit() {
		source.PlayOneShot (pingbutton);
		Application.Quit();
	}
}

// Script by Yago Hübner