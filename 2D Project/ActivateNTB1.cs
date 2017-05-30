using UnityEngine;
using System.Collections;

public class ActivateNTB1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Activate () {

		GameObject.FindWithTag("Notebook1").GetComponent<Notebook1>().SetBook1(1);

	}

}
