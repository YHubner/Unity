using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    public  Vector2     jumpForce = new Vector2(0, 300);
	private Rigidbody2D rb;

	public Text bronze;
	public Text silver;
	public Text gold;
	private int bronzescore = 0;
	private int silverscore = 0;
	private int goldscore = 0;

	public GameObject gameover;
	public GameObject player;

	public Text Timer;
	public Text bscore;
	public Text sscore;
	public Text gscore;

	public void Start() {
		rb = GetComponent<Rigidbody2D>();

		bronze.text = "0";
		silver.text = "0";
		gold.text = "0";

		bscore.text = "0";
		sscore.text = "0";
		gscore.text = "0";

		//resetar star...chamar componente por aqui,do ground

		gameover.SetActive(false);

	}

    public void Update() {
        if (Input.GetKeyUp("space")) {
            rb.velocity = Vector2.zero;
            rb.AddForce(jumpForce);
        }

		if (Input.GetKeyDown(KeyCode.Return)) {
			Time.timeScale = 1;
			SceneManager.LoadScene(0);
		}

        // Die by being off screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
            Die();
    }

    public void OnTriggerEnter2D(Collider2D hit) {
		if (hit.gameObject.tag == "obstaculo"){
			Die();
		}

		if (hit.gameObject.tag == "bronzestar"){
			bronzescore = bronzescore + 1;
			int points = (int) bronzescore;
			bronze.text = string.Format("{0}" ,points);
			bscore.text = bronze.text;
		}

		if (hit.gameObject.tag == "silverstar"){
			silverscore = silverscore + 1;
			int points = (int) silverscore;
			silver.text = string.Format("{0}" ,points);
			sscore.text = silver.text;
		}

		if (hit.gameObject.tag == "goldstar"){
			goldscore = goldscore + 1;
			int points = (int) goldscore;
			gold.text = string.Format("{0}" ,points);
			gscore.text = gold.text;
			//fazer o reset com o start
		}

    }

    void Die() {

		Time.timeScale = 0;
		gameover.SetActive(true);
		GameObject.FindWithTag("MainHUD").GetComponent<Canvas>().enabled = false;
		GameObject.FindWithTag("timer").GetComponent<Cronometer>().hudTime = Timer;
		//SceneManager.LoadScene(0);
		//GameObject.FindWithTag("ScreenCount").GetComponent<ScreenCount>().SetScreenCollected(3);
    }
}