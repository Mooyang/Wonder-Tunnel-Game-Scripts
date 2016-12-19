using UnityEngine;
using System.Collections;

public class colliderSound : MonoBehaviour {

	public AudioSource source;
	public AudioClip clip;

	void Awake(){
	
		source = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider other){
		
		if (other.gameObject.tag == "vehicle") {
			if (!source.isPlaying) {
				source.Play ();
			}
		}
	}

	void OnTriggerExit(Collider other){
		
		if (other.gameObject.tag == "vehicle") {
			if (source.isPlaying) {
				source.Stop ();	
			}
		}
	}


}
