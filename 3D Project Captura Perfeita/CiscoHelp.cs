using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CiscoHelp : MonoBehaviour {

	public GameObject Death;
	public GameObject Activation;
	public AudioClip accept;
	public AudioSource source;
	public float timer;
	// Use this for initialization
	void Start () {
		timer = 0;
		Activation.SetActive(false);

		GameObject.FindWithTag ("PressX").GetComponent<Text> ().enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= 30f) {
			GameObject.FindWithTag ("PressX").GetComponent<Text> ().enabled = true;
			if (Input.GetKeyDown (KeyCode.X)) {
				source.PlayOneShot (accept);
				Death.SetActive (false);
				GameObject.FindWithTag ("PressX").GetComponent<Text> ().enabled = false;
				GameObject.FindWithTag ("Cisco").GetComponent<AnimationCisco> ().Ativa (3);
				GameObject.FindWithTag ("Cisco").GetComponent<CiscoOut> ().enabled = true;
				Activation.SetActive (true);
				timer = 0;
			}

		}
	}
}
