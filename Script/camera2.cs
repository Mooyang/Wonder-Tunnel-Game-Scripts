using UnityEngine;
using System.Collections;

public class camera2 : MonoBehaviour {

	void OnTriggerEnter(Collider other){
	
		if (other.gameObject.tag == "vehicle") {
			
			this.gameObject.SetActive (false);
		}
	}
		
}
