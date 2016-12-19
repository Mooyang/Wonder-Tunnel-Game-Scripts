using UnityEngine;
using System.Collections;

public class SPplaneCollider : MonoBehaviour {

	public GameObject ui;

	// Use this for initialization
	void Start () {

		ui.SetActive (false);
	
	}


	void OnTriggerEnter(Collider other){
	
		if (other.gameObject.tag == "vehicle") {
			Debug.Log ("Check Heart");
            //ui.SetActive (true);
            TunnelControl.arrowL = true;
			StartCoroutine (close ());
		}
	}	
		

	void OnTriggerExit(Collider other){
	
		ui.SetActive (false);
        TunnelControl.arrowL = false;

    }

	IEnumerator close (){

		yield return new WaitForSeconds (1.7f);
		ui.SetActive (false);
		gameObject.SetActive (false);

	}

}
