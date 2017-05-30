using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Cronometer : MonoBehaviour {

		public Text hudTime;
		private int sign = 1;
		private float timer;

		void Start () {

			timer = 0;
			sign = +1;

			hudTime.text = "00:00";
		}

		void Update () {
			timer = timer + sign * Time.deltaTime;
			int minutes = (int) (timer / 60);
			int seconds = (int) (timer % 60);
			hudTime.text = string.Format ("{0:00}:{1:00}", minutes, seconds);

		}
	}