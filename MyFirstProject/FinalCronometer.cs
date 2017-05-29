using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class FinalCronometer : MonoBehaviour {

	public Transform respawnFinal;
	public Text hudTime;
	public float maxTime = 120;
	private int sign = 1;
	private float timer;
	
	void Start () {

			timer = maxTime;
			sign = -1;

		hudTime.text = "00:00";
	}
	
	void Update () {
		timer = timer + sign * Time.deltaTime;
		int minutes = (int) (timer / 60);
		int seconds = (int) (timer % 60);
		hudTime.text = string.Format ("{0:00}:{1:00}", minutes, seconds);

		if (timer <= -1){
			GameObject.FindWithTag("Player").transform.position = respawnFinal.position;
			timer = 0;
			sign = 0;
		}

	}
}