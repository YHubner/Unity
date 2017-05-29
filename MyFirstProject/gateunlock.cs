using UnityEngine;
using System.Collections;

public class gateunlock : MonoBehaviour {

	private bool key;

	public void SetKeyCollected(int i) {
		if (i == 1) key = true;
		
		if (key == true) {
			print ("Door Unlocked");
			GameObject.Destroy (gameObject);
		}
    }
}
