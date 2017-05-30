using System;
using UnityEngine;
using TouchScript.Gestures;
using Random = UnityEngine.Random;

namespace TouchScript.Examples.Tap
{
	public class BreakAsteroid : MonoBehaviour
	{
		public float Power = 0.1f;

		private TapGesture TapGesture;
		//private PressGesture pressGesture;
		private MeshRenderer rnd;
		private bool growing = false;
		private float growingTime = 0;

		private Vector3[] directions =
		{
			new Vector3(1, -1, 1),
			new Vector3(-1, -1, 1),
			new Vector3(-1, -1, -1),
			new Vector3(1, -1, -1),
			new Vector3(1, 1, 1),
			new Vector3(-1, 1, 1),
			new Vector3(-1, 1, -1),
			new Vector3(1, 1, -1)
		};

		private void OnEnable()
		{
			rnd = GetComponent<MeshRenderer>();
			TapGesture = GetComponent<TapGesture>();
			//pressGesture = GetComponent<PressGesture>();

			TapGesture.StateChanged += TapHandler;
			//pressGesture.Pressed += pressedHandler;
		}

		private void OnDisable()
		{
			TapGesture.StateChanged -= TapHandler;
			//pressGesture.Pressed -= pressedHandler;
		}

		private void Update()
		{
			if (growing)
			{
				growingTime += Time.deltaTime;
				rnd.material.color = Color.Lerp(Color.white, Color.red, growingTime);
			}
		}

		private void startGrowing()
		{
			growing = true;
		}

		private void stopGrowing()
		{
			growing = false;
			growingTime = 0;
			rnd.material.color = Color.white;
		}
			

		private void TapHandler(object sender, GestureStateChangeEventArgs e)
		{
			if (e.State == Gesture.GestureState.Recognized)
			{
				// if we are not too small
				if (transform.localScale.x > 0.03f)
				{
					// break this cube into 8 parts
					for (int i = 0; i < 8; i++)
					{
						var obj = Instantiate(gameObject) as GameObject;
						var asteroid = obj.transform;
						asteroid.parent = transform.parent;
						asteroid.name = "Asteroid";
						asteroid.localScale = 0.5f*transform.localScale;
						asteroid.position = transform.TransformPoint(directions[i]/4);
						asteroid.GetComponent<Rigidbody>().AddForce(Power*Random.insideUnitSphere, ForceMode.Impulse);
						asteroid.GetComponent<Renderer>().material.color = Color.white;
					}
					Destroy(gameObject);
				}
			}
			else if (e.State == Gesture.GestureState.Failed)
			{
				stopGrowing();
			}
		}
	}
}