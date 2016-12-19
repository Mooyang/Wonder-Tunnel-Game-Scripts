using UnityEngine;
using System.Collections;

public class TutCheckScene : MonoBehaviour {

	public GameObject oop, loading, vehicle; 

	// Use this for initialization
	void Start () {

		oop.SetActive (false);
		loading.SetActive (false);
	
	}

	void OnTriggerEnter(Collider other){
	
		if (other.tag == "vehicle") {
		
			oop.SetActive (true);
			StartCoroutine (close());
		}
	}

	IEnumerator close(){
	
		yield return new WaitForSeconds (3f);
		oop.SetActive (false);
		vehicle.SetActive (false);
		loading.SetActive (true);

		yield return new WaitForSeconds (3f);
		loading.SetActive (false);
		Application.LoadLevel ("Menu");

	}

}
