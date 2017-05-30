using UnityEngine;
using System.Collections;

public class SoundControl : MonoBehaviour {

	public AudioClip foley;
	public AudioSource source;

	public void PlaySound (int sound){
		source.PlayOneShot (foley);
	}
}