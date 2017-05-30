using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TopCameraControl2 : MonoBehaviour {

	public GameObject youshallnotpass;
	private bool TopView = false;


	// Use this for initialization
	void Start()
	{

		GameObject.FindWithTag("PressV").GetComponent<Text>().enabled = false;

	}

	// Update is called once per frame
	void Update()
	{

		if (TopView == true && Input.GetKeyDown(KeyCode.V))
		{
			GameObject.FindWithTag("TopViewCamera2").GetComponent<Camera>().enabled = true;
			GameObject.FindWithTag("TopViewCamera2").GetComponent<AudioSource>().enabled = true;
			GameObject.FindWithTag("MainCamera").GetComponent<Camera>().enabled = false;
			GameObject.FindWithTag("MainHUD").GetComponent<Canvas>().enabled = false;
			youshallnotpass.SetActive(false);
		}

		if (TopView == true && Input.GetKeyUp(KeyCode.V))
		{
			GameObject.FindWithTag("TopViewCamera2").GetComponent<Camera>().enabled = false;
			GameObject.FindWithTag("TopViewCamera2").GetComponent<AudioSource>().enabled = false;
			GameObject.FindWithTag("MainCamera").GetComponent<Camera>().enabled = true;
			GameObject.FindWithTag("MainHUD").GetComponent<Canvas>().enabled = true;
		}

	}

	public void OnTriggerEnter(Collider hit)
	{

		if (hit.gameObject.tag == "Player")
		{
			TopView = true;
			GameObject.FindWithTag("PressV").GetComponent<Text>().enabled = true;

		}
	}
	public void OnTriggerExit(Collider hit)
	{

		TopView = false;
		GameObject.FindWithTag("TopViewCamera2").GetComponent<Camera>().enabled = false;
		GameObject.FindWithTag("PressV").GetComponent<Text>().enabled = false;
		GameObject.FindWithTag("MainCamera").GetComponent<Camera>().enabled = true;
		GameObject.FindWithTag("MainHUD").GetComponent<Canvas>().enabled = true;
	}
}

// Script by Yago Hübner