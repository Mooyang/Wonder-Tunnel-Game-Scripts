using UnityEngine;
using System.Collections;

public class loading : MonoBehaviour {

	void Start(){
	
		this.gameObject.SetActive (false);
	}

	public void show(){

		Invoke ("wait", 4.5f);

	}

	void wait(){

		this.gameObject.SetActive (true);
	}
}
