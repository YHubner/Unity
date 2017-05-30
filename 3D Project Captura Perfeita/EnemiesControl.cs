using UnityEngine;
using System.Collections;

public class EnemiesControl : MonoBehaviour {


	void Start() {

		GameObject.FindWithTag("CiscoEnemy1").GetComponent<CiscoOut>().enabled = false;
		GameObject.FindWithTag("CiscoEnemy2").GetComponent<CiscoOut>().enabled = false;
		GameObject.FindWithTag("CiscoEnemy3").GetComponent<CiscoOut>().enabled = false;


	}

	// Update is called once per frame
	void Update() {




	}
	void OnTriggerEnter(Collider hit)
	{
		if (hit.gameObject.tag == "Cisco") {
			GameObject.FindWithTag("CiscoEnemy1").GetComponent<EnemiesRunAnimation>().Ativa(1);
			GameObject.FindWithTag("CiscoEnemy2").GetComponent<EnemiesRunAnimation>().Ativa(1);
			GameObject.FindWithTag("CiscoEnemy3").GetComponent<EnemiesRunAnimation>().Ativa(1);
			GameObject.FindWithTag("CiscoEnemy1").GetComponent<CiscoOut>().enabled = true;
			GameObject.FindWithTag("CiscoEnemy2").GetComponent<CiscoOut>().enabled = true;
			GameObject.FindWithTag("CiscoEnemy3").GetComponent<CiscoOut>().enabled = true;

		}
	}
}