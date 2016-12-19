using UnityEngine;
using System.Collections;

public class BoxRoad : MonoBehaviour {

	public AudioClip clip;
	public AudioSource source;
	public CrashCheck1 camShake;
	public GameObject ui, boxRoadPar, boxRoad;
	//public Rigidbody rb;



	// Use this for initialization
	void Start () {

		//rb = GetComponent<Rigidbody> ();
		source = GetComponent<AudioSource> ();
		clip = GetComponent<AudioClip> ();
        //ui.SetActive (false);
		boxRoadPar.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
	
		if (other.gameObject.tag == "vehicle") {
		
			Debug.Log ("crash Box Road");
			HpBar.hpScore -= 0.1f;
			control.sp -= 10;
			source.Play ();
			boxRoad.SetActive (false);
            //ui.SetActive (true);
            TunnelControl.red = true;
            boxRoadPar.SetActive (true);
			camShake.cameraShake ();
			StartCoroutine (close ());
		}
	}
		

	IEnumerator close(){

		yield return new WaitForSeconds (0.5f);
		source.Stop ();
        //ui.SetActive (false);
        TunnelControl.red = false;
        boxRoadPar.SetActive (false);
		gameObject.SetActive (false);

	}
}
