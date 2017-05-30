using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Telephone : MonoBehaviour {

	public float maxTime = 10;
	public bool increaseTime = true;
	private int sign = 1;
	private float timer;
	public GameObject wave;
	public GameObject wave1;
	public GameObject colisor;

	void Start () {
		if (increaseTime){
			timer = 0;
			sign = 1;
		} 
	}

	void Update () {
		timer = timer + sign * Time.deltaTime;
		int minutes = (int) (timer / 60);
		int seconds = (int) (timer % 60);

		if (timer >= maxTime){
			sign = -1;
		}

		if (timer <= 0){
			sign = +1;
		}

		if (timer > 5){
			
			colisor.SetActive(false);
			wave.SetActive(false);
			wave1.SetActive(false);
		}

		if (timer < 5){

			colisor.SetActive(true);
			wave.SetActive(true);
			wave1.SetActive(true);
		}

	}
}