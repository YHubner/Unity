using UnityEngine;
using System.Collections;

public class DodgeViper : MonoBehaviour {

	public float 	 speed = 10;
	public float 	 rotSpeed = 80;
	public Rigidbody bullet;
	public Transform muzzle;
	public float 	 force = 1000;

	private Rigidbody rb;
	
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	void Update () {

		if (Input.GetMouseButtonDown (0)){
			Rigidbody b = GameObject.Instantiate (bullet,muzzle.position,muzzle.rotation) as Rigidbody ;
			b.AddForce (muzzle.up * force);
		}

		rb.MovePosition (transform.position + transform.forward * speed * Time.deltaTime * Input.GetAxis ("Vertical"));
		transform.Rotate (0, rotSpeed * Time.deltaTime * Input.GetAxis ("Horizontal"),0);
	}

}
	