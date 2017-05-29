using UnityEngine;
using System.Collections;

public class TurretControl : MonoBehaviour {

	public Transform   target;
	public Transform   gun;
	public Rigidbody   bulletturret;
	public Transform   muzzleppsh;
	public float 	   force = 1000;
	public AudioSource shootSound;
	public float       frequency = 2;
	private float 	   timer;
	private bool 	   activate = false;
	
	void Update () {

		if(!activate) return; // nao faz oq ta embaixo

		gun.LookAt (target.position);
		//transform.rotation = Quaternion.FromToRotation (transform.up, transform.forward) * transform.rotation;

		timer += Time.deltaTime;
		if (timer >= frequency){
			timer = 0;
			
			Rigidbody b = GameObject.Instantiate (bulletturret,muzzleppsh.position,muzzleppsh.rotation) as Rigidbody ;
			b.AddForce (muzzleppsh.up * force);
			
			shootSound.Play();
		}
	}

	public void OnTriggerEnter(Collider hit){
		if (hit.gameObject.tag == "Player")
			activate = true;
	}
	public void OnTriggerExit(Collider hit){
		if (hit.gameObject.tag == "Player")
			activate = false;
	
	}
}
