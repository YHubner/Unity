/*
 * 
 * Como chamar coisas fora do scrit atual.
 * 
 * 
 * using UnityEngine;
using System.Collections;

public class call : MonoBehaviour {

	public void OnTriggerEnter(Collider hit){
		if (hit.gameObject.tag == "Target"){
			GameObject.FindWithTag("lantern").GetComponent<FlickLight>().flick = true;// Findwithtag puxa uma tag(Objeto)
		}                                                                             // GetComponent (Flicklight como script) e flick como classe dentro desse script)
	}
*/