using UnityEngine;
using System.Collections;

public class slipperR : MonoBehaviour {

	public AudioClip clip;
	public AudioSource source;
	public GameObject vehicle;

    public TunnelControl sendTrue;
    public bool chon = false;

    // Use this for initialization
    void Start () {
		source = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("vehicle"))
        {

            sendTrue.RoL = false;
            sendTrue.RoR = true;
            chon = true;

            // Debug.Log ("slipperR");
            //source.Play ();
            //vehicle.transform.Translate (30 , 0, 0);
        }
    }
}
