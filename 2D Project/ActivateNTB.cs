using UnityEngine;
using System.Collections;

public class ActivateNTB : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Activate () {

		GameObject.FindWithTag("Notebook").GetComponent<Notebook>().SetBook(1);

	}

}
