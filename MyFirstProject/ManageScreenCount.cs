using UnityEngine;
using System.Collections;

public class ManageScreenCount : MonoBehaviour {
	private bool pcscreen1;
	private bool pcscreen2;
	private bool pcscreen3;
	private bool pcscreen4;

	public void SetScreenCollected(int i) {
		if (i == 1) pcscreen1 = true;
		if (i == 2) pcscreen2 = true;
		if (i == 3) pcscreen3 = true;
		if (i == 4) pcscreen4 = true;

		if (pcscreen1 && pcscreen2 && pcscreen3 && pcscreen4) {
			print ("Door Unlocked");
			GameObject.Destroy (gameObject);
		}

	}
}
