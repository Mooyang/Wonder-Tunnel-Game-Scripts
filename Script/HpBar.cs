using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HpBar : MonoBehaviour {

	public GameObject textUI, showScore, vehicle, boom;
	public static float hpScore;
	Image image;

	// Use this for initialization
	void Start () {

		image = GetComponent<Image> ();
		textUI.SetActive (false);
		showScore.SetActive (false);
		boom.SetActive (false);
		hpScore = 1f;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		image.fillAmount = hpScore;

		if (hpScore <= 0f) {
		
			vehicle.SetActive (false);
			textUI.SetActive (false);
			boom.SetActive (true);
			showScore.SetActive (true);
		}

		if (hpScore >= 0.3f) {
		
			textUI.SetActive (false);
		}

		if (hpScore < 0.3f && hpScore > 0f ) {

			textUI.SetActive (true);

		}
	}
		
}
