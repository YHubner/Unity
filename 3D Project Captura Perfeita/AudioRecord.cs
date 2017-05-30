using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AudioRecord : MonoBehaviour {
	
	public AudioClip record;
	public AudioSource source;
	public Image AudioBar;
	public GameObject youshallnotpass;
	public bool unpause;
	public bool first = true;

	// Use this for initialization
	void Start () {
	
		AudioBar.fillAmount = 0;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerStay(Collider hit){

		if (hit.gameObject.tag == "Player"){
			AudioBar.fillAmount += 0.0004F;
			if (AudioBar.fillAmount > 0.999){

				GameObject.FindWithTag("Player").GetComponent<Collect>().Target(1);
				print ("Audio Collected");
                AudioBar.enabled = false;
				youshallnotpass.SetActive(false);
                GameObject.Destroy(gameObject);
            }
			   
		}
	}
	public void PlaySound (int sound){
		if (sound == 0){
			source.PlayOneShot(record);
		}
}
}
// Script by Yago Hübner