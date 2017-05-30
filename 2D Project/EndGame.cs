using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {

	public void OnCollisionEnter2D (Collision2D hit)
	{

		if (hit.gameObject.tag == "End") 
		{
			Application.LoadLevel (3);
		}
	}			
}
