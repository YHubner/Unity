using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tutorial : MonoBehaviour {

	public Image comojogar;


	void Start () {
	
		comojogar.enabled = false;

	}

	void Update () {
	
	}

	public void OnTriggerEnter(Collider hit)
	{
		comojogar.enabled = true;
	}

	public void OnTriggerExit(Collider hit)
	{
		comojogar.enabled = false;
	}
}
