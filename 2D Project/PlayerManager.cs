using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {
	private InputState     inputState;
	private Walk           walkBehavior;
	private Animator       animator;
	private CollisionState collisionState;
	private Duck           duckBehavior;

	public Image firedBar;
	public int Score = 0;
	public Text ScoreText;

	public GameObject Door1;
	public GameObject Door2;
	public GameObject Final;

	public void Awake() {
		inputState     = GetComponent<InputState>();
		walkBehavior   = GetComponent<Walk>();
		animator       = GetComponent<Animator>();
		collisionState = GetComponent<CollisionState>();
		duckBehavior   = GetComponent<Duck>();

		ScoreText.text = "Bonus: " + Score.ToString();
	}

	public void Update() {
		if (collisionState.standing) {
			ChangeAnimationState(0);
		}

		if (inputState.absVelX > 0) {
			ChangeAnimationState(1);
		}

		if (inputState.absVelY > 0) {
			ChangeAnimationState(2);
		}

		animator.speed = walkBehavior.running ? walkBehavior.runMultiplier : 1;

		if (duckBehavior.ducking) {
			ChangeAnimationState(3);
		}


		if (!collisionState.standing && collisionState.onWall) {
			ChangeAnimationState(4);
		}

		if (collisionState.onWall) {
			ChangeAnimationState(5);
		}



	}

	public void ChangeAnimationState(int value){
		animator.SetInteger("AnimState", value);
	}

	public void OnCollisionEnter2D (Collision2D hit)
	{

		if (hit.gameObject.tag == "Notebook") 
		{
			firedBar.fillAmount += 0.07f;
		}

		if (hit.gameObject.tag == "Notebook1") 
		{
			firedBar.fillAmount += 0.07f;
		}

		if (hit.gameObject.tag == "Notebook2") 
		{
			firedBar.fillAmount += 0.07f;
		}

	}

	public void OnTriggerEnter2D (Collider2D hit)
	{

		if (firedBar.fillAmount >= 1) 
		{
		
			GameObject.FindWithTag("GameOver").GetComponent<GameOver>().SetGameOver(1);
		}

		if (hit.gameObject.tag == "Bonus") 
		{
			GameObject.Destroy (hit.gameObject);
			Score += 10;
			Pontuacao ();

		}

		if (hit.gameObject.tag == "Rat") 
		{
			firedBar.fillAmount += 0.07f;
		}

		if (hit.gameObject.tag == "End") 
		{
			Final.SetActive (true);
			GameObject.FindWithTag("Final").GetComponent<Animator>().enabled = true;

		}

	}

	public void OnTriggerStay2D (Collider2D hit)
	{

		if (hit.gameObject.tag == "garbage") 
		{
			firedBar.fillAmount += 0.001f;
		}

		if (hit.gameObject.tag == "telephone") 
		{
			firedBar.fillAmount += 0.003f;
		}


	}

	public void Pontuacao()
	{
		ScoreText.text = "Bonus: " + Score.ToString();

		if (Score == 40) 
		{
			Door1.SetActive (false);
		}

		if (Score == 80) 
		{
			Door1.SetActive (false);
		}

	}
}
