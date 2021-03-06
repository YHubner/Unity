﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TopCameraControl : MonoBehaviour
{

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
			GameObject.FindWithTag("TopViewCamera").GetComponent<Camera>().enabled = true;
			GameObject.FindWithTag("TopViewCamera").GetComponent<AudioSource>().enabled = true;
			GameObject.FindWithTag("MainCamera").GetComponent<Camera>().enabled = false;
            GameObject.FindWithTag("MainHUD").GetComponent<Canvas>().enabled = false;
			youshallnotpass.SetActive(false);
        }

		if (TopView == true && Input.GetKeyUp(KeyCode.V))
		{
			GameObject.FindWithTag("TopViewCamera").GetComponent<Camera>().enabled = false;
			GameObject.FindWithTag("TopViewCamera").GetComponent<AudioSource>().enabled = false;
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
        GameObject.FindWithTag("TopViewCamera").GetComponent<Camera>().enabled = false;
        GameObject.FindWithTag("PressV").GetComponent<Text>().enabled = false;
        GameObject.FindWithTag("MainCamera").GetComponent<Camera>().enabled = true;
        GameObject.FindWithTag("MainHUD").GetComponent<Canvas>().enabled = true;
    }
}

// Script by Yago Hübner