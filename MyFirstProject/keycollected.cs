using UnityEngine;
using System.Collections;

public class keycollected : MonoBehaviour {

	public void OnTriggerEnter(Collider hit)  {

		if (hit.gameObject.tag == "Player"){
			GameObject.FindWithTag("gateunlock").GetComponent<gateunlock>().SetKeyCollected(1);
			print ("keycollected");
			GameObject.Destroy (gameObject);
		}
}
}
