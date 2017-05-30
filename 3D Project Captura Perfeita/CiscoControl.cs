using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CiscoControl : MonoBehaviour {

	public GameObject youshallnotpass;

	void Start() {

		youshallnotpass.SetActive(false);
		GameObject.FindWithTag("Cisco").GetComponent<FSMCisco>().enabled = false;
		GameObject.FindWithTag("PressX").GetComponent<Text>().enabled = false;
		GameObject.FindWithTag("Cisco").GetComponent<CiscoHelp>().enabled = false;
		GameObject.FindWithTag("Cisco").GetComponent<CiscoOut>().enabled = false;

	}

	// Update is called once per frame
	void Update() {




	}
	void OnTriggerEnter(Collider hit)
	{
		if (hit.gameObject.tag == "Player") {
			GameObject.FindWithTag("Cisco").GetComponent<AnimationCisco>().Ativa(1);
			GameObject.FindWithTag("Cisco").GetComponent<FSMCisco>().enabled = true;
			youshallnotpass.SetActive(true);
			Destroy (gameObject);
		}
	}
}