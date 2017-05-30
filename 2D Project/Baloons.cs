using UnityEngine;
using System.Collections;

public class Baloons : MonoBehaviour {

	public float maxTime = 2;
	public bool increaseTime = true;
	private int sign = 1;
	private float timer;
	public GameObject bl1;
	public GameObject bl2;
	public GameObject bl3;
	public GameObject bl4;
	public GameObject bl5;

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

		if (timer > 1){

			bl1.SetActive(false);
			bl2.SetActive(false);
			bl3.SetActive(false);
			bl4.SetActive(false);
			bl5.SetActive(false);
		}

		if (timer < 1){

			bl1.SetActive(true);
			bl2.SetActive(true);
			bl3.SetActive(true);
			bl4.SetActive(true);
			bl5.SetActive(true);
		}

	}
}
