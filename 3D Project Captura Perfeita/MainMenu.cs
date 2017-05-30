using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NewGame() {
		Application.LoadLevel(2);
	}
		
	public void Credits() {
		Application.LoadLevel(3);
	}

	public void Quit() {
		Application.Quit();
	}

}

// Script by Yago Hübner
