using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeScore : MonoBehaviour {

	public GameObject vehicle, ui, boom, ShowScore;
	public static int score;
	public static int Score;
	private int addDecrease;
	Text text;

	// Use this for initialization
	void Start () {

		addDecrease = 1; 
		text = GetComponent<Text> ();
		score = 15000;
		Score = score / 20;
		ui.SetActive (false);
		boom.SetActive (false);
	
	}

	// Update is called once per frame
	void Update () {

        if (score > 15000) {

           score = 15000;
        }

		//addDecrease += 1/2;

		Score = score / 20;
		//score -= 1;

		if (score > 0) {

			score -= 1;
			text.text = "" + Score;
		}

		if (Score < 20) {

			ui.SetActive (true);
		}

		if (Score > 20) {

			ui.SetActive (false);
		}

		if (Score < 1) {

			ui.SetActive (false);
			boom.SetActive (true);
			ShowScore.SetActive (true);
			vehicle.SetActive (false);
	
		}
	
	}
		
}
