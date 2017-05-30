using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GoToPlayer : MonoBehaviour {

	public Transform Player;
	public bool movimento = true;
	public int speed;
	public float 	   force = 10;

	void Start () {

		Quaternion movement;
		movement = Quaternion.LookRotation(Player.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, movement, 6f * Time.deltaTime);
	}
		
	void Update () {

		if (movimento == true) {
			Move ();
		}

		if (transform.position == Player.position) {
			//movimento = false;
		}

	}

	void Move()
	{
		transform.position = Vector3.MoveTowards (transform.position, Player.position, speed * Time.deltaTime);


	}
}