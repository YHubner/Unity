using UnityEngine;
using System.Collections;

public class SimpleMovement : MonoBehaviour {
	public  float       speed = 5f;
	public  Buttons[]   input;
	private Rigidbody2D body2d;
	private InputState  inputState;

	public void Start () {
		body2d     = GetComponent<Rigidbody2D>();
		inputState = GetComponent<InputState>();
	}

	public void Update() {
		bool  right = inputState.GetButtonValue(input[0]);
		bool  left  = inputState.GetButtonValue(input[1]);
		float velX  = speed;

		if (right || left) {
			velX *= left ? -1 : 1;
		} else {
			velX = 0;
		}

		body2d.velocity = new Vector2(velX, body2d.velocity.y);
	}
}
