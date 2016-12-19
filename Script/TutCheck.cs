using UnityEngine;
using System.Collections;

public class TutCheck : MonoBehaviour {

	public GameObject TutUI;
	public float showtime;

	void Start () {
		showtime = 1f;
		TutUI.SetActive (false);

	}


	void OnTriggerEnter(Collider other){

		Debug.Log ("enter Tut R L");
	
		if (other.tag == "vehicle") {
		
			TutUI.SetActive (true);
			StartCoroutine (close());
		}
	}

	IEnumerator close(){
		yield return new WaitForSeconds (showtime);
		TutUI.SetActive (false);

	}

}
