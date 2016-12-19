using UnityEngine;
using System.Collections;

public class BoxCrash : MonoBehaviour {


	public CrashCheck1 camShake;
	public GameObject boxPar, boxTrap, ui;

	// Use this for initialization
	void Start () {
	
		boxPar.SetActive (false);
		ui.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
	
		if (other.gameObject.tag == "vehicle") {
		
			boxPar.SetActive (true);
            //ui.SetActive (true);
            //camShake.cameraShake ();
            TunnelControl.red = true;
			HpBar.hpScore -= 0.1f;
			control.sp -= 10;
			boxTrap.SetActive (false);
			StartCoroutine (close());
		}
	}
		

	IEnumerator close(){

		yield return new WaitForSeconds (0.5f);
        TunnelControl.red = false;

        yield return new WaitForSeconds (1);
		boxPar.SetActive (false);
		gameObject.SetActive (false);

	}
}
