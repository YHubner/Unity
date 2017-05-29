using UnityEngine;
using System.Collections;

public class SoundControl : MonoBehaviour {

	public AudioClip collectKey;
	public AudioClip collectAmmo;
	public AudioClip collectLife;
	public AudioSource source;

	public void PlaySound (int sound){
		if (sound == 0){
			source.PlayOneShot(collectKey);

		}
		if (sound == 1){
			source.PlayOneShot(collectLife);
	}
		if (sound == 2){
			source.PlayOneShot(collectAmmo);
		}
  }
}