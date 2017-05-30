using UnityEngine;
using System.Collections;

public class WaypointControl : MonoBehaviour {

	static Color     linkColor     = Color.green;
	public Color     waypointColor = Color.red;
	public float     radius        = 0.1F;
	public Transform next;

	public void OnDrawGizmos() {
		Gizmos.color = waypointColor;
		Gizmos.DrawSphere(transform.position, radius);
		if (next != null) {
			Gizmos.color = linkColor;
			Gizmos.DrawLine(transform.position, next.position);
		}
	}
}

// Script by Yago Hübner