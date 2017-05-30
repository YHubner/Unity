using UnityEngine;
using System.Collections;

public class EnemiesRunAnimation : MonoBehaviour {

	// Use this for initialization

	private Animator run;

	void Start () {

		run = GetComponent<Animator> ();

		run.SetBool("Run",false);


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Ativa (int i) {
		if (i == 1) run.SetBool("Run",true);
	}
}
