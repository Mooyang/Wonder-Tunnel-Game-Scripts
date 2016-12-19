using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnergyBar : MonoBehaviour {

	public GameObject textUI;
	public static float energyScore;
	Image image;

	// Use this for initialization
	void Start () {

		image = GetComponent<Image>();
		energyScore = 1f;
		textUI.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		image.fillAmount = energyScore;

		if (energyScore < 1f) {
			
			energyScore += 0.001f;
		}

		if (energyScore <= 0.01) {

			Debug.Log ("Energy Done");
			textUI.SetActive (false);
		}

		if (energyScore < .3f && energyScore > 0.01f) {
			Debug.Log ("Low Energy");
			textUI.SetActive (true);
		}
		 
		if (energyScore > .3f) {
			textUI.SetActive (false);
		}
			
	}

}
