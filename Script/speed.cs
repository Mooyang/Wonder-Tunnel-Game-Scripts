using UnityEngine;
using System.Collections;

public class speed : MonoBehaviour {

	public AudioClip clip;
	public AudioSource source;
	public GameObject speedPar;

	// Use this for initialization
	void Start () {

		source = GetComponent<AudioSource> ();
		speedPar.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
	
		if (other.CompareTag  ("vehicle")) {
		
			if (control.sp < 300) {
				Debug.Log ("speed up");
				control.maxSp = 300;
				control.sp += 20;
                //speedPar.SetActive (true);
                TunnelControl.speeder = true;
				source.Play ();
				StartCoroutine (close ());
			}
		}
	}

	IEnumerator close(){
	
		yield return new WaitForSeconds (5);
		Debug.Log ("Speed Done");
		source.Stop ();
		//speedPar.SetActive (false);
		control.sp -= 20;
		control.maxSp = 200;
	}
}
