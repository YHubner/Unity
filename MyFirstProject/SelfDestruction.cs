using UnityEngine;

public class SelfDestruction : MonoBehaviour {

	public float lifetime = 5;
	
	void Start () {
		GameObject.Destroy (gameObject, lifetime);
	}
}
