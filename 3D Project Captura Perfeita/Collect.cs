using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Collect : MonoBehaviour {

	private bool sound;
	private bool photo;
    private bool photo2;
    private bool drug;

	public GameObject youshallnotpass;
	public GameObject youshallnotpass2;
	public GameObject youshallnotpass3;

	public Image SoundImage;
	public Image DrugImage;
    public Image KeyPhotoCheck;
    public Image KeyPhoto2Check;
    private int currentTrophy;

	void Start () {

		SoundImage.enabled = false;

		DrugImage.enabled = false;
        KeyPhotoCheck.enabled = false;
        KeyPhoto2Check.enabled = false;

    }

    void Update()
    {

        if (sound == true)
        {
            print("soundcheck");
            SoundImage.enabled = true;
        }
        if (photo == true)
        {
            KeyPhotoCheck.enabled = true;
			youshallnotpass2.SetActive(false);
        }
        if (photo2 == true)
        {
            KeyPhoto2Check.enabled = true;
        }
		if (drug == true)
		{
			print("dooorgas");
			DrugImage.enabled = true;
		}
   }

    public void Target (int i) {
		if (i == 1) sound = true;
        if (i == 2) photo = true; // toda vez q for dois dá acrescenta um check
        if (i == 3) photo2 = true;
    }

	public void OnTriggerEnter(Collider hit)
	{

		if (hit.gameObject.tag == "Drug")
		{
			GameObject.Destroy(hit.gameObject);
			drug = true;
			youshallnotpass3.SetActive(false);
			}

		if (hit.gameObject.tag == "File")
		{
			GameObject.Destroy(hit.gameObject);
			youshallnotpass.SetActive(false);
		}

		}
	}

// Script by Yago Hübner