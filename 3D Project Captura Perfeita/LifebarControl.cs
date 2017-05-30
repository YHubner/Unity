using UnityEngine;
using System.Collections;

public class LifebarControl : MonoBehaviour {

	public Transform target;

	void Start () {

	}


	void Update () {
		transform.LookAt (target.position);
		transform.eulerAngles = new Vector3 (0, transform.eulerAngles.y, 0);
	}
}

// Script by Yago Hübner