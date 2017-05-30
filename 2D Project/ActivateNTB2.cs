using UnityEngine;
using System.Collections;

public class ActivateNTB2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Activate () {

		GameObject.FindWithTag("Notebook2").GetComponent<Notebook2>().SetBook2(1);

	}

}
