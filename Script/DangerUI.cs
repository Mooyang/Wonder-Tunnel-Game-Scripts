using UnityEngine;
using System.Collections;

public class DangerUI : MonoBehaviour {

	public GameObject ui;
	public AudioClip clip;
	public AudioSource source;

	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
		ui.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	

	}

	void OnTriggerEnter(Collider other){
		
		if (other.gameObject.tag == "vehicle") {
			if (!source.isPlaying) {
				source.Play ();
			}
            //ui.SetActive (true);
            TunnelControl.danger = true;
		}
	}

	void OnTriggerExit(Collider other){
		
		if (other.gameObject.tag == "vehicle") {
			if (source.isPlaying) {
				source.Stop ();	
			}

            //ui.SetActive (false);
            TunnelControl.danger = false;
        }
	}

}
