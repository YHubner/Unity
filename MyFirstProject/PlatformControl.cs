using UnityEngine;
using System.Collections;

public class PlatformControl : MonoBehaviour {

	public void OnTriggerEnter (Collider hit){
		if (hit.gameObject.tag == "plat") {
			transform.parent = hit.transform;
		}
	}

	public void OnTriggerExit (Collider hit) {
		if (hit.gameObject.tag == "plat") {
			transform.parent = null;
		}
	}
}
