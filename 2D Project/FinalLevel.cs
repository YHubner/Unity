using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FinalLevel : MonoBehaviour {

	public GameObject Door3;
	public GameObject Baloons;

	// Use this for initialization
	void Start () {
	
		Baloons.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter2D (Collider2D hit)
	{

		if (hit.gameObject.tag == "Player") 
		{
			Door3.SetActive (true);
			Baloons.SetActive (true);

		}
	}
}
