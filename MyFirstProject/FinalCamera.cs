using UnityEngine;
using System.Collections;


public class FinalCamera : MonoBehaviour {
	
	void Start () {


		GameObject.FindWithTag("camerafinal").GetComponent<Camera>().enabled = false;
		GameObject.FindWithTag("camerafinal").GetComponent<AudioListener>().enabled = false;
		ParticleSystem particle = (ParticleSystem)gameObject.GetComponent("ParticleSystem");
		particle.enableEmission = false;

	}

	
	public void OnTriggerEnter(Collider hit){
		if (hit.gameObject.tag == "playerbullet1"){

			// atirar construçao
			GameObject.FindWithTag("vipercam").GetComponent<Camera>().enabled = false;
			GameObject.FindWithTag("vipercam").GetComponent<AudioListener>().enabled = false;
			GameObject.FindWithTag("camerafinal").GetComponent<Camera>().enabled = true;
			GameObject.FindWithTag("camerafinal").GetComponent<AudioListener>().enabled = true;
			ParticleSystem particle = (ParticleSystem)gameObject.GetComponent("ParticleSystem");
			particle.enableEmission = true;
		}
	}
}
