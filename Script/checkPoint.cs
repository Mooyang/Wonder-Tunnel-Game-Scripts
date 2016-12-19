using UnityEngine;
using System.Collections;

public class checkPoint : MonoBehaviour {

	public AudioClip checkpoint;
	public AudioSource source;
	private int CheckValue = 200;

	// Use this for initialization
	void Start () {
	
		source = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		
		if (other.gameObject.tag == "vehicle") {
			if (TimeScore.score <= 800) {
				TimeScore.score += CheckValue;
				Debug.Log ("Time Increase");
			}
			source.Play ();
		}

	}
}
