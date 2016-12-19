using UnityEngine;
using System.Collections;

public class slipperL : MonoBehaviour {

	public AudioClip clip;
	public AudioSource source;
	public GameObject vehicle;

    public TunnelControl sendTrue;
    public bool chon = false;

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("vehicle"))
        {

            sendTrue.RoL = true;
            sendTrue.RoR = false;
            chon = true;

            //Debug.Log ("slipperL");
            source.Play();
            //vehicle.transform.Translate (-30 , 0, 0);
        }
    }
}
