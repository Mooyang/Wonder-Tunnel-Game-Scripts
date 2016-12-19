using UnityEngine;
using System.Collections;

public class CrashCheck1 : MonoBehaviour {

	public bool Shaking; 
	private float ShakeDecay;
	private float ShakeIntensity;  
	private Vector3 OriginalPos;
	private Animation anim;
	public AudioSource source;
	public GameObject spark;

	// Use this for initialization
	void Start () {
	
		Shaking = false; 
		anim = GetComponent<Animation>();
		source = GetComponent<AudioSource> ();
		spark.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {



		if(ShakeIntensity > 0)
		{
			transform.position = OriginalPos + Random.insideUnitSphere * ShakeIntensity;
			ShakeIntensity -= ShakeDecay;
		}
		else if (Shaking)
		{
			Shaking = false;  
			transform.position = OriginalPos;
		}
	
	}


	public void cameraShake(){

		OriginalPos = transform.position;
		ShakeIntensity = 7f;
		ShakeDecay = 30f;
		Shaking = true;
		Debug.Log ("camera shake"); 
		spark.SetActive (true);
		StartCoroutine (close ());
	}

	IEnumerator close(){
	
		yield return new WaitForSeconds (2);
		spark.SetActive (false);
	}

}
