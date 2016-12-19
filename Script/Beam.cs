using UnityEngine;
using System.Collections;

public class Beam : MonoBehaviour {

	public CrashCheck1 camShake;
	public AudioClip beamMove, crashBeam;
	public AudioSource source;

	// Use this for initialization
	void Start () {

		source = GetComponent<AudioSource> ();
		gameObject.SetActive (false);

	}
		
	// Update is called once per frame
	void Update () {
	
		transform.Translate(0,0,-150*Time.deltaTime);
		source.PlayOneShot (beamMove, 0.5f);
		StartCoroutine (close2());

	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "vehicle") {

			if(source.isPlaying)
			source.Stop ();
			
			Debug.Log ("crash beam");
			source.clip = crashBeam;
			source.loop = true;
			source.Play();
            TunnelControl.blue = true;
			HpBar.hpScore -= 0.1f;
			control.sp -= 15;
			//camShake.cameraShake();
			StartCoroutine (close ());


		}
	}

	IEnumerator close(){

		yield return new WaitForSeconds (1f);
        TunnelControl.blue = false;
		gameObject.SetActive (false);

	}

	IEnumerator close2(){
		yield return new WaitForSeconds (2.5f);
        gameObject.SetActive (false);

	}
}
