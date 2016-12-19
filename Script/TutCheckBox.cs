using UnityEngine;
using System.Collections;

public class TutCheckBox : MonoBehaviour {

	public GameObject oop; 

	// Use this for initialization
	void Start () {

		oop.SetActive (false);
	
	}

	void OnTriggerEnter(Collider other){

		Debug.Log ("Oop!!");
	
		if (other.tag == "vehicle") {
		
			oop.SetActive (true);

			StartCoroutine (close());
		}
	}

	IEnumerator close(){
	
		yield return new WaitForSeconds (.5f);
		oop.SetActive (false);
		Application.LoadLevel ("practice");

	}

}
