using UnityEngine;
using System.Collections;

public class AnimationCisco : MonoBehaviour {

	private Animator move;
	private Animator run;

	// Use this for initialization
	void Start () {

		move = GetComponent<Animator> ();
		move.SetBool("Move",false);

		run = GetComponent<Animator> ();
		run.SetBool("Run",false);

	}

	// Update is called once per frame
	void Update () {



	}

	public void Ativa (int i) {
		if (i == 1) move.SetBool("Move",true);
		if (i == 2) move.SetBool("Move",false);
		if (i == 3) run.SetBool("Run",true);
	}
}
