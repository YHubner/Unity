using UnityEngine;
using System.Collections;

public class bulletcollider : MonoBehaviour {

	public void OnCollisionEnter (Collision hit){
		if (hit.gameObject.tag == "turret"){
			GameObject.Destroy (hit.gameObject);
		}
	}
}
