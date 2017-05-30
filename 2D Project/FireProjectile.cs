using UnityEngine;
using System.Collections;

public class FireProjectile : AbstractBehavior {
	public  float      shootDelay = .5f;
	public  GameObject projectilePrefab;
	private float      timeElapsed = 0f;


	public void Update() {
		if (projectilePrefab != null) {
			bool canFire = inputState.GetButtonValue(inputButtons[0]);

			if(canFire && timeElapsed > shootDelay){
				CreateProjectile(transform.position);
				timeElapsed = 0;
			}

			timeElapsed += Time.deltaTime;
		}
	}

	public void CreateProjectile(Vector2 pos){
		GameObject clone           = Instantiate(projectilePrefab, pos, Quaternion.identity) as GameObject;
		clone.transform.localScale = transform.localScale;
	}
}
