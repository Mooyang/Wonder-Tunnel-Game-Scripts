using UnityEngine;
using System.Collections;

public class heartItem : MonoBehaviour {

	public GameObject heartPar, Item;


	// Use this for initialization
	void Start () {

		heartPar.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "vehicle") {
			Debug.Log ("Keep Heart");
			HpBar.hpScore += 0.2f;
			Item.SetActive (false);
			heartPar.SetActive (true);
			StartCoroutine (close());
		}
	}
		

	IEnumerator close(){
	
		yield return new WaitForSeconds (1f);
		heartPar.SetActive (false);
		gameObject.SetActive (false);
	}

}
