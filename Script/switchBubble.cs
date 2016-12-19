using UnityEngine;
using System.Collections;

public class switchBubble : MonoBehaviour {

	public AudioClip clip;
	public GameObject bubble, BBswitch;
	public AudioSource source;
	public CrashCheck1 camShake;

	// Use this for initialization
	void Start () {

		source = GetComponent<AudioSource> ();
		bubble.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
	
		if (other.gameObject.tag == "vehicle") {

			Debug.Log ("crash switch bubble");
			source.Play ();
			HpBar.hpScore -= 0.1f;
			control.sp -= 5;
			Debug.Log ("Bubbles");
			bubble.SetActive (true);
			//camShake.cameraShake ();
			StartCoroutine (close());
		}
	}

	IEnumerator close(){

		yield return new WaitForSeconds (0.5f);
		gameObject.SetActive (false);
		BBswitch.SetActive (false);

		yield return new WaitForSeconds (3);
		bubble.SetActive (false);
	}




}
