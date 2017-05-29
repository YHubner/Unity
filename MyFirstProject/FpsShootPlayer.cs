using UnityEngine;
using UnityEngine.UI;

public class FpsShootPlayer : MonoBehaviour {

	public Animator gate;
	public Transform respawnSpikes;
	public Transform respawnPoint;
	public Rigidbody   bulletppsh;
	public Transform   muzzleppsh;
	public float 	   force = 1000;
	public AudioSource shootSound;
	public Image lifeBar;
	public Image ammo;//
	public Image[] trophies;
	private int increasetime = 0;
	private float timer;
	private int currentTrophy;

	void Start () {

		timer = 0;

		gate.enabled = false;

		for (int i = 0; i < trophies.Length; i++){
			trophies[i].enabled = false;
		}
		currentTrophy = 0;
	}

	void Update () {

		timer = timer + increasetime * Time.deltaTime;

		if (timer >= 5){
			GameObject.FindWithTag("cameragate").GetComponent<Camera>().enabled = false;
		}


		if (ammo.fillAmount > 0)//
		if (Input.GetMouseButtonDown (0)){
			ammo.fillAmount -= 0.05F;//
			Rigidbody b = GameObject.Instantiate (bulletppsh,muzzleppsh.position,muzzleppsh.rotation) as Rigidbody ;
			b.AddForce (muzzleppsh.up * force);
			shootSound.Play();

		}

  }
	      
	public void OnTriggerEnter(Collider hit){
		if (hit.gameObject.tag == "heart"){
			GameObject.Destroy(hit.gameObject);
			lifeBar.fillAmount += 0.05F;
			if (lifeBar.fillAmount > 1)
				lifeBar.fillAmount = 1;
			GameObject.FindWithTag("soundcontrol").GetComponent<SoundControl>().PlaySound (1);// linha mais importante do semestre

		}

		if (hit.gameObject.tag == "ammo"){
			GameObject.Destroy(hit.gameObject);
			ammo.fillAmount = 1;
			GameObject.FindWithTag("soundcontrol").GetComponent<SoundControl>().PlaySound (2);
			
		}

		if (hit.gameObject.tag == "enemybullet"){
			GameObject.Destroy(hit.gameObject);
			lifeBar.fillAmount -= 0.05F;
			if (lifeBar.fillAmount <= 0)
			Application.LoadLevel (Application.loadedLevel);
		}
		if (hit.gameObject.tag == "target") {
			GameObject.Destroy(hit.gameObject);
			GameObject.FindWithTag("soundcontrol").GetComponent<SoundControl>().PlaySound (0);
			trophies[currentTrophy].enabled = true;
			currentTrophy++;
			if (currentTrophy >= trophies.Length){
				currentTrophy = trophies.Length - 1;
				//load animation to enable lastroom
				GameObject.FindWithTag("cameragate").GetComponent<Camera>().enabled = true;
				gate.enabled = true;
				increasetime = 1;


			}
		}
		if (hit.gameObject.tag == "death"){
			transform.position = respawnPoint.position;
		}
		if (hit.gameObject.tag == "spikes"){
			transform.position = respawnSpikes.position;
		}
	}
}