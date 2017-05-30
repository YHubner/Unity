using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PhotoAreaFinal : MonoBehaviour {


	private bool Photography;
	private bool activate;

	// Use this for initialization
	void Start () {

		GameObject.FindWithTag("TakePicture").GetComponent<Text>().enabled = false;
		GameObject.FindWithTag("Player").GetComponent<TakePictureFinal>().enabled = false;
	}

	void Update () {

		if(Input.GetButtonDown ("Aim"))
			activate = true;

		if(Input.GetButtonUp ("Aim"))
			activate = false;


		if (Photography == true && activate == true){

			GameObject.FindWithTag("TakePicture").GetComponent<Text>().enabled = true;
			GameObject.FindWithTag("Player").GetComponent<TakePictureFinal>().enabled = true;
		}

		else
		{

			GameObject.FindWithTag("TakePicture").GetComponent<Text>().enabled = false;
			GameObject.FindWithTag("Player").GetComponent<TakePictureFinal>().enabled = false;
		}

	}

	public void OnTriggerEnter(Collider hit)
	{

		if (hit.gameObject.tag == "Enemy" )
		{
			Photography = true;
		}
	}

	public void OnTriggerExit(Collider hit)
	{

		if (hit.gameObject.tag == "Enemy")
		{
			Photography = false;
		}
	}
}

// Script by Yago Hübner