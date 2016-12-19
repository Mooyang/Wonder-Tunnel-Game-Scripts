using UnityEngine;
using System.Collections;

public class circleOpen : MonoBehaviour {

	public void PlayAnimation(){

		GetComponent<Animator> ().SetInteger ("circle", 1);	

	}
		
}
