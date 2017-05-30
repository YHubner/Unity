using UnityEngine;
using System.Collections;

public class Notebook : MonoBehaviour {

	private bool book;
	public  Vector2     jumpForce = new Vector2(400, 400);
	private Rigidbody2D rb;
	private Vector3 startPos;


	void Start () {
	
		rb = GetComponent<Rigidbody2D>();
		startPos = transform.position;
	}

	public void SetBook(int i) {

		if (i == 1) book = true;


		if (book == true) {

			rb.velocity = Vector2.zero;
			rb.AddForce(jumpForce);
			transform.position = startPos;

		}
	}
}