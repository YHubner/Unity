using UnityEngine;
using System.Collections;

public class AnimationEnemy : MonoBehaviour {

	private Animator move;

	// Use this for initialization
	void Start () {
	
		move = GetComponent<Animator> ();
		move.SetBool("Move",false);

	}
	
	// Update is called once per frame
	void Update () {
	


	}

	public void Ativa (int i) {
		if (i == 1) move.SetBool("Move",true);
		if (i == 2) move.SetBool("Move",false);
	}
}
