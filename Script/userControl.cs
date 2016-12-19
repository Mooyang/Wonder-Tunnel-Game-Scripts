using UnityEngine;
using System.Collections;

public class userControl : MonoBehaviour {


	void Start () {

	}

	void Update () {

		if(Input.GetKey(KeyCode.Space)){

			transform.Translate (0, 1, 0);
		}

		if (Input.GetKey (KeyCode.A)) {

			transform.Rotate(0,-1,0);

		}
		if (Input.GetKey (KeyCode.D)) {

			transform.Rotate(0,1,0);

		}
		if (Input.GetKey (KeyCode.W)) {

			transform.Rotate(-1,0,0);

		}
		if (Input.GetKey (KeyCode.S)) {

			transform.Rotate(1,0,0);

		}




		if (Input.GetKey (KeyCode.LeftArrow)) {

			transform.Translate (-1,0,0);

		}
		if (Input.GetKey (KeyCode.RightArrow)) {

			transform.Translate(1,0,0);

		}
		if (Input.GetKey (KeyCode.UpArrow)) {

			transform.Translate(0,0,1);

		}
		if (Input.GetKey (KeyCode.DownArrow)) {

			transform.Translate(0,0,-1);

		}



	}



}
