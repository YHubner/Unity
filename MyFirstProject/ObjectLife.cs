using UnityEngine;
using System.Collections;

public class ObjectLife : MonoBehaviour {

	public float life = 3;
	
	public void OnCollisionEnter(Collision hit){
		if (hit.gameObject.tag == "playerbullet"){
			
			life = life - 1;
			if (life == 0) {
				GameObject.Destroy(gameObject);
			}
		}
	}
}
