using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FSMSimple : MonoBehaviour {

	public Image NPClifeBar;

	#region FSM States
	public enum      FSMStates { Waypoints, Chasing, Shooting, Firing ,Death };
	public FSMStates state = FSMStates.Waypoints;
	#endregion

	#region Generic Variable
	public  GameObject target;
	public  float      speed;
	public  float      rotSpeed;
	private float      timer;
	private Vector3    dir;
	private Rigidbody  rb;
	#endregion

	#region Wapypoints
	public  Transform[] waypoints;
	public  float       distanceToChangeWaypoint;
	private int         currentWaypoint;
	#endregion

	#region Chasing
	public float distanceToStartChasing;
	public float distanceToStopChasing;
	public float distanceToAttack;
	public float distanceToReturnChase;
	public float chanceToFire;
	#endregion

	#region Shooting
	public Rigidbody bullet;
	public Transform muzzle;
	public float     bulletInitialForce;
	public float     frequency;
	public int       numberOfShoots;
	public int       maxNumberOfShoots;

	#endregion

	#region Firing
	public GameObject flame;
	public float      flameTime;
	#endregion

	#region Death
	#endregion

	#region Unity Functions
	public void Start() {
		currentWaypoint = 0;
		timer           = 0;
		rb              = GetComponent<Rigidbody>();
		flame.SetActive(false);


	}


	public void FixedUpdate() {
		dir = target.transform.position - transform.position;

		switch (state) {
		case FSMStates.Waypoints: WaypointState(); break;
		case FSMStates.Chasing:   ChaseState();    break;
		case FSMStates.Shooting:  ShootState();    break;
		case FSMStates.Firing:    FireState();     break;
		case FSMStates.Death:    DeathState();     break;

		default: print("BUG: state should never be on default clause"); break;
		}
	}
	#endregion

	#region Wapypoints State
	private void WaypointState() {
		// Check if target is in range to chase
		if (dir.magnitude <= distanceToStartChasing) {
			state = FSMStates.Chasing;
			return;
		}

		// Find the direction to the current waypoint,
		//   rotate and move towards it
		Vector3 wpDir         = waypoints[currentWaypoint].position - transform.position;
		transform.rotation    = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(wpDir), Time.deltaTime * rotSpeed);
		transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
		if (wpDir.sqrMagnitude <= distanceToChangeWaypoint) {
			currentWaypoint++;
			if (currentWaypoint >= waypoints.Length)
				currentWaypoint = 0;

		} else
			rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
	}
	#endregion

	#region Chasing State
	private void ChaseState() {
		// Check if target is close enough to shoot or fire
		//   or if target is too far way, then return to Waypoints
		if (dir.magnitude > distanceToStopChasing) {
			state = FSMStates.Waypoints;
			return;
		} else if (dir.magnitude <= distanceToAttack) {
			timer = 0;
			rb.velocity = Vector3.zero;
			// Get a random number to choose one of the attacks
			float randomNumber = UnityEngine.Random.Range(0F, 10F);
			if (randomNumber > chanceToFire) {
				state = FSMStates.Firing;
				flame.SetActive(true);
			} else {
				state = FSMStates.Shooting;
				numberOfShoots = 0;
			}
			return;
		}

		transform.rotation    = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotSpeed);
		transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
		rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
	}
	#endregion

	#region Shooting State
	private void ShootState() {
		transform.rotation    = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotSpeed);
		transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

		timer += Time.deltaTime;
		if (timer >= frequency) {
			timer = 0;

			Rigidbody b = GameObject.Instantiate(bullet, muzzle.position, muzzle.rotation) as Rigidbody;
			b.AddForce(muzzle.forward * bulletInitialForce);
			//GameObject.FindWithTag("soundcontrol").GetComponent<SoundControl>().PlaySound("shoot");

			numberOfShoots++;
			if (numberOfShoots >= maxNumberOfShoots) {
				if (dir.magnitude < distanceToAttack)
					numberOfShoots = 0;
				else if (dir.magnitude > distanceToAttack && dir.magnitude <= distanceToReturnChase)
					state = FSMStates.Chasing;
				else if (dir.magnitude > distanceToReturnChase)
					state = FSMStates.Waypoints;
			}
		}
	}
	#endregion

	#region Firing State
	private void FireState() {
		transform.rotation    = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * rotSpeed);
		transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

		timer += Time.deltaTime;
		if (timer >= flameTime) {
			timer = 0;

			if (dir.sqrMagnitude > distanceToAttack && dir.magnitude <= distanceToReturnChase) {
				state = FSMStates.Chasing;
				flame.SetActive(false);
			}
			else if (dir.magnitude > distanceToReturnChase) {
				state = FSMStates.Waypoints;
				flame.SetActive(false);
			}
		}
	}
	#endregion

	#region Death State
	private void DeathState() {

		print ("Npc died");
		GameObject.Destroy(gameObject);

	}

	#endregion

	public void OnCollisionEnter(Collision hit) {
		if (hit.gameObject.tag == "playerbullet"){
			GameObject.Destroy(hit.gameObject);
			NPClifeBar.fillAmount -= 0.1F;
			if (NPClifeBar.fillAmount <= 0)
				state = FSMStates.Death;
		}
	}
}

// Script by Yago Hübner