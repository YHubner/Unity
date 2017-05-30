using UnityEngine;
using System.Collections;


public class AnimationControl : MonoBehaviour {

	public AudioClip record;
	public AudioSource source;

	//private Animator move;

    // Use this for initialization
    void Start() {

		GameObject.FindWithTag("EnemyAudio2").GetComponent<FSMPointToPoint>().enabled = false;
		GameObject.FindWithTag("EnemyAudio3").GetComponent<FSMPointToPoint2>().enabled = false;
    }

    // Update is called once per frame
    void Update() {




    }
    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player") {
            GameObject.FindWithTag("EnemyAudio").GetComponent<Animator>().enabled = true;
			GameObject.FindWithTag ("EnemyAudio").GetComponent<AudioRecord>().PlaySound(0);
			GameObject.FindWithTag("ListeneeAnim").GetComponent<AnimationEnemy>().Ativa(1);
			GameObject.FindWithTag("ListeneeAnim2").GetComponent<AnimationEnemy2>().Ativa(1);
			GameObject.FindWithTag("EnemyAudio2").GetComponent<FSMPointToPoint>().enabled = true;
			GameObject.FindWithTag("EnemyAudio3").GetComponent<FSMPointToPoint2>().enabled = true;

			//move.SetBool("Move",true);
        }
    }
}