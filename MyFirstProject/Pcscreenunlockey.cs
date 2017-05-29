using UnityEngine;

public class Pcscreenunlockey : MonoBehaviour {
	
	public void OnTriggerEnter(Collider hit)  {
		if (hit.gameObject.tag == "pc1"){
			GameObject.FindWithTag("ScreenCount").GetComponent<ManageScreenCount>().SetScreenCollected(1);
			print ("Pcscreen1 hit");
		}
			
		if (hit.gameObject.tag == "pc2"){
			GameObject.FindWithTag("ScreenCount").GetComponent<ManageScreenCount>().SetScreenCollected(2);
			print ("Pcscreen2 hit");
		}

		if (hit.gameObject.tag == "pc3"){
			GameObject.FindWithTag("ScreenCount").GetComponent<ManageScreenCount>().SetScreenCollected(3);
			print ("Pcscreen3 hit");
		}

		if (hit.gameObject.tag == "pc4"){
			GameObject.FindWithTag("ScreenCount").GetComponent<ManageScreenCount>().SetScreenCollected(4);
			print ("Pcscreen4 hit");
		}
	}
}
