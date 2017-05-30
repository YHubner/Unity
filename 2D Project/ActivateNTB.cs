using UnityEngine;
using System.Collections;

public class ActivateNTB : MonoBehaviour {


	public void Activate () {

		GameObject.FindWithTag("Notebook").GetComponent<Notebook>().SetBook(1);

	}

}
