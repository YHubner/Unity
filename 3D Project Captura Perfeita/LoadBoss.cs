using UnityEngine;
using System.Collections;

public class LoadBoss : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider hit)
	{
		if (hit.gameObject.tag == "Player") {

			Application.LoadLevel (4);
		}
	}
}
