using UnityEngine;
using System.Collections;

public class BeamCheck : MonoBehaviour {

	public GameObject beam;
	// Use this for initialization
	void Start () {

		//ui.SetActive (false);
	
	}
	

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "vehicle") {

			Debug.Log ("Beam Check");
			beam.SetActive (true);
            TunnelControl.warning = true;
			StartCoroutine (close());
					
		}
	}
		

	IEnumerator close(){
	
		yield return new WaitForSeconds (1f);
        TunnelControl.warning = false;
        gameObject.SetActive (false);
	}
}
