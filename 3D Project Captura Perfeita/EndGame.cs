using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	public GameObject Cutscene;
	public GameObject Pitbull;
	public GameObject NewPit;
	public GameObject Vareta;
	public GameObject NewVareta;


	// Use this for initialization
	void Start () {
	

		Cutscene.SetActive (false);
		NewPit.SetActive (false);
		NewVareta.SetActive (false);


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider hit)
	{
		if (hit.gameObject.tag == "Enemy") {

			Cutscene.SetActive (true);
			Pitbull.SetActive (false);
			NewPit.SetActive (true);
			NewVareta.SetActive (true);
			Vareta.SetActive (false);

		}

	}
}
