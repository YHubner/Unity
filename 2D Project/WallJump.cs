using UnityEngine;
using System.Collections;

public class WallJump : AbstractBehavior {
	public  bool    jumpingOffWall;
	public  Vector2 jumpVelocity = new Vector2(50, 200);
	public  float   resetDelay   = .2f;
	private float   timeElapsed  = 0;
	
	public void Update() {
		if (collisionState.onWall && !collisionState.standing) {
			bool canJump = inputState.GetButtonValue(inputButtons[0]);

			if (canJump && !jumpingOffWall) {
				ToggleScripts(false);
				inputState.direction = inputState.direction == Directions.Right ? Directions.Left : Directions.Right;
				body2d.velocity      = new Vector2(jumpVelocity.x * (float)inputState.direction, jumpVelocity.y);
				jumpingOffWall       = true;
			}
		}

		if (jumpingOffWall) {
			timeElapsed += Time.deltaTime;

			if (timeElapsed > resetDelay) {
				ToggleScripts(true);
				jumpingOffWall = false;
				timeElapsed    = 0;
			}
		}
	}
}
