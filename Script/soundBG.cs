using UnityEngine;
using System.Collections;

public class soundBG : MonoBehaviour {

	public AudioClip[] BGsound;
	private AudioSource source;


	// Use this for initialization
	void Start () {

		source = GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {

		if (source.isPlaying)
			return;
		
		else {

			int random = Random.Range (0, BGsound.Length);
			source.PlayOneShot(BGsound[random],0.5f);
				
		}
			
	
	}
		
}
