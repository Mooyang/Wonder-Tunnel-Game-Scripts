using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class timer : MonoBehaviour {

	float Timer;
	public static int intTimer;
	Text text;

	// Use this for initialization
	void Start () {

		Timer = 0;
		intTimer = 0;
		text = GetComponent<Text> ();
	
	}
	
	// Update is called once per frame
	void Update () {

//		if(HpBar.hpScore <= 0 || TimeScore.Score <= 0){
//
//			return;
//		}
				
			Timer += 1 * Time.timeSinceLevelLoad;
			intTimer = Mathf.FloorToInt (Timer);
			text.text = "" + intTimer;
	
	}
}
