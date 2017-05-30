using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollectDrug : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		GameObject.FindWithTag("DisplayDrug").GetComponent<Text>().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter(Collider hit)
	{

		if (hit.gameObject.tag == "Player")
		{
			GameObject.FindWithTag("DisplayDrug").GetComponent<Text>().enabled = true;

		}
	}
}
