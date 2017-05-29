using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

	private int increasetime = 0;
	private float timer;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<ParticleSystem>().enableEmission = false;
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {

		timer = timer + increasetime * Time.deltaTime;

		if (timer >= 2){
			Application.LoadLevel(2);
		}


	
	}
	public void OnTriggerEnter(Collider hit){
		if (hit.gameObject.tag == "playerbullet1"){
			gameObject.GetComponent<ParticleSystem>().enableEmission = true;
			increasetime = 1;

		}

}
}