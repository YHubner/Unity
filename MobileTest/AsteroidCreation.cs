using UnityEngine;
using System.Collections;

public class AsteroidCreation : MonoBehaviour {

	public Transform   target;
	public Transform   asteroidlauncher;
	public Rigidbody   asteroid;
	public Transform   muzzle;
	public float 	   force = 1000;
	public float       frequency = 5;
	private float 	   timer;
	private bool 	   activate = true;

	void Update () {

		if(!activate) return; // nao faz oq ta embaixo

		asteroidlauncher.LookAt (target.position);
		//transform.rotation = Quaternion.FromToRotation (transform.up, transform.forward) * transform.rotation;

		timer += Time.deltaTime;
		if (timer >= frequency){
			timer = 0;

			Rigidbody b = GameObject.Instantiate (asteroid,muzzle.position,muzzle.rotation) as Rigidbody ;
			b.AddForce (muzzle.forward * force);
		}
	}
}