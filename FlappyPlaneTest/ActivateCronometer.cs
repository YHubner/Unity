using UnityEngine;
using System.Collections;

public class ActivateCronometer : MonoBehaviour {

	public  GameObject   activatecronometer;
	public  float        rockSpeed;


	// Use this for initialization
	void Start () {
	
		GameObject.FindWithTag("timer").GetComponent<Cronometer>().enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
	
		activatecronometer.transform.Translate(-rockSpeed * Time.deltaTime, 0, 0);

	}

	public void OnTriggerEnter2D(Collider2D hit) {

		if (hit.gameObject.tag == "Player"){
			GameObject.FindWithTag("timer").GetComponent<Cronometer>().enabled = true;
			GameObject.Destroy(gameObject);
		}
	}
}