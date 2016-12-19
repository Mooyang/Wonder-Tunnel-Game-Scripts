using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class wheelTrap : MonoBehaviour {

	public GameObject explosion, ui, machine, dangerUI;
	public CrashCheck1 camShake;

	void Start () {
		
		explosion.SetActive (false);
	}
	


	void OnTriggerEnter(Collider other){

	
		if (other.gameObject.tag == "vehicle") {
		
			Debug.Log ("crash Wheel");
			explosion.SetActive (true);
            TunnelControl.red = true;
			HpBar.hpScore -= 0.2f;
			control.sp -= 20;
			Debug.Log ("Boom");
			//camShake.cameraShake ();
			machine.SetActive (false);
           // TunnelControl.danger = true;
			StartCoroutine (close());
		}
	}

	IEnumerator close(){
	
		yield return new WaitForSeconds (1.5f);
        //TunnelControl.danger = false;
        TunnelControl.red = false;
        explosion.SetActive (false);
        gameObject.SetActive (false);
	}

}
