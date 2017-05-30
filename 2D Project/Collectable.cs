using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Collectable : MonoBehaviour {
	public string targetTag = "Player";

	public Image lifeBar;

	public void OnTriggerEnter2D (Collider2D target){
		if (target.gameObject.tag == targetTag) {
			OnCollect(target.gameObject);
			OnDestroy();
		}
	}

	protected virtual void OnCollect(GameObject target){

		print ("Vida");
		lifeBar.fillAmount += 0.05f;

	}

	protected virtual void OnDestroy(){
		Destroy(gameObject);
	}
}
