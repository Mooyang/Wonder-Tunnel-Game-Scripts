using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	

	void Start () {

	}

	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			
			transform.Rotate(0,-5,0);
			
		}
		if (Input.GetKey (KeyCode.D)) {
			
			transform.Rotate(0,5,0);
			
		}
		if (Input.GetKey (KeyCode.W)) {
			
			transform.Rotate(-5,0,0);
			
		}
		if (Input.GetKey (KeyCode.S)) {
			
			transform.Rotate(5,0,0);
			
		}

	

	}


	
}
