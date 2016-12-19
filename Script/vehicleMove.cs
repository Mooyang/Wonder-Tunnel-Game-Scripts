
using UnityEngine;
using System.Collections;

public class vehicleMove : MonoBehaviour {

	public void PlayAnimation(){

		StartCoroutine (wait());	

	}

	IEnumerator wait(){

		yield return new WaitForSeconds (2);
		GetComponent<Animator> ().SetInteger ("moveVehicle", 1);
	}
}
