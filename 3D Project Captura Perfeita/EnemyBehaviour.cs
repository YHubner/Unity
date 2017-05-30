using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

	public Transform SignalObject;
	public Transform HBPoint;
	public bool movimento;
	public int speed;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (movimento == true) {
			Move ();
		} else {
			Moveback ();
		}

	}

	void Move()
	{
		Quaternion movement;
		movement = Quaternion.LookRotation(SignalObject.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, movement, 6f * Time.deltaTime);
		transform.position = Vector3.MoveTowards (transform.position, SignalObject.position, speed * Time.deltaTime);


	}	

	void Moveback()
	{
		Quaternion movement2;
		movement2 = Quaternion.LookRotation(HBPoint.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, movement2, 6f * Time.deltaTime);
		transform.position = Vector3.MoveTowards (transform.position, HBPoint.position, speed * Time.deltaTime);
	}
}
