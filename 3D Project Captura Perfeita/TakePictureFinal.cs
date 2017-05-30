using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TakePictureFinal : MonoBehaviour {

	public AudioClip photo;
	public AudioSource source;

	// Use this for initialization
	void Start () {

		GameObject.FindWithTag("TakePicture").GetComponent<Text>().enabled = false;
		GameObject.FindWithTag("Player").GetComponent<TakePictureFinal>().enabled = false;

	}

	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Shoot")){

			GameObject.FindWithTag("Player").GetComponent<CollectFinal>().Target(2);
			PlaySound ();
		}

	}
	public void PlaySound (){
		source.PlayOneShot(photo);

	}
}

// Script by Yago Hübner
