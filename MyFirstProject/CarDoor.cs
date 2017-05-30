using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class CarDoor : MonoBehaviour {
	
	public Animator lastgate;
	
	void Start () {

		lastgate.enabled = false;
		GameObject.FindWithTag("vipercam").GetComponent<AudioListener>().enabled = false;
	}

	public void OnTriggerEnter(Collider hit){
		if (hit.gameObject.tag == "Player"){
			GameObject.Destroy(hit.gameObject);
			GameObject.FindWithTag("canvas").GetComponent<Canvas>().enabled = false;
			GameObject.FindWithTag("MainCamera").GetComponent<AudioListener>().enabled = false;
			//ativa carro
			GameObject.FindWithTag("dodgeviper").GetComponent<DodgeViper>().enabled = true;
			GameObject.FindWithTag("vipercam").GetComponent<Camera>().enabled = true;
			GameObject.FindWithTag("vipercam").GetComponent<AudioListener>().enabled = true;
			lastgate.enabled = true;
		}
	}
}
