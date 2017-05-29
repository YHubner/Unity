using UnityEngine;
using System.Collections;

public class microteleport : MonoBehaviour {
	
	public float distance = 3;

	void Update () {
		if (Input.GetKeyDown(KeyCode.T)) {
		transform.Translate(transform.forward * distance, Space.World);

		}
	}
}
