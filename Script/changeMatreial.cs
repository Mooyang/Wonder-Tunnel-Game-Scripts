using UnityEngine;
using System.Collections;

public class changeMatreial : MonoBehaviour {

	public Material[] materials;
	public float changeInterval = 0.1f;
	public Renderer rend;

	// Use this for initialization
	void Start () {

		rend = GetComponent<Renderer> ();
		rend.enabled = true;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (materials.Length == 0) {
		
			return;
		}

		int index = Mathf.FloorToInt (Time.time / changeInterval);
		index = index % materials.Length;

		rend.sharedMaterial = materials [index];
	

	}
}
