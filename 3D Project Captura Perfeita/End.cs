using UnityEngine;
using System.Collections;

public class End : MonoBehaviour {

	public float lifeTime = 2;

	public void Start() {

		GameObject.Destroy(gameObject, lifeTime);
		//Application.LoadLevel(3);
	}
}