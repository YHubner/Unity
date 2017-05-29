using UnityEngine;

public class CameraControl : MonoBehaviour {

	public Transform respawnPoint;
	public GameObject animationRoot;
	public float 	  allertTime = 5;
	public float	  gameOverTime = 1;
	private float	  timerAllert;
	private float	  timerGameOver;
	private bool	  startAllert;
	private bool	  startCountDown;
	

	void Start () {
		timerAllert    = 0;
		timerGameOver  = 0;
		startAllert    = false;
		startCountDown = false;
	
	}


	void Update () {
		if (startAllert)  {
			timerAllert += Time.deltaTime;
			if (timerAllert >= allertTime) {
				animationRoot.GetComponent<Animator>().enabled = true;
				startAllert	   = false;
				startCountDown = false;
				timerAllert    = 0;
				timerGameOver  = 0;
				return; //encerra a funçao
				}
			}
			if (startCountDown) {
				timerGameOver += Time.deltaTime;
				if (timerGameOver >= gameOverTime) {
					GameObject.FindWithTag("Player").transform.position = respawnPoint.position;
					print ("Failed, you were spotted!");
			    }
			}
	}

	public void OnTriggerEnter(Collider hit)  {
		if (hit.gameObject.tag == "Player")	 {
			if (!startAllert)  {
				startAllert   = true;
				timerAllert   = 0;
				timerGameOver = 0;
				animationRoot.GetComponent<Animator>().enabled = false;
			}

			if (!startCountDown)
				startCountDown = true;

		}
	}

	public void OnTriggerExit (Collider hit)  {
		if (hit.gameObject.tag == "Player")  {
			startCountDown = false;
		}
	}


}