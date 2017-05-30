using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	public void QuitToMenu() {
		Time.timeScale = 1;
		Application.LoadLevel(1);
	}
}

// Script by Yago Hübner