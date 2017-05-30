using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public GameObject GameOver;
	public GameObject Propeller;

	void Start () {
	
		GameOver.SetActive(false);
		Propeller.SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter () {

		GameOver.SetActive(true);
		Propeller.SetActive(false);

	}
}
