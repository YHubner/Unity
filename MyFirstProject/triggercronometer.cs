using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class triggercronometer : MonoBehaviour {
	
	void Start () {
	
	}

	void Update () {
	
	}

public void OnTriggerEnter(Collider hit){
	if (hit.gameObject.tag == "Player"){
			GameObject.FindWithTag("canvas").GetComponent<FinalCronometer>().enabled = true;
			GameObject.FindWithTag("timeractivate").GetComponent<Text>().enabled = true;
		}
	}
}
