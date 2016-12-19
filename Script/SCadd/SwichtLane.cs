using UnityEngine;
using System.Collections;

public class SwichtLane : MonoBehaviour {

    public Transform[] laneL;

    public float speed = 5.0f;
    public float reachDist = 1.0f;  
    public int currentPoint = 0;



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        float dist = Vector3.Distance(laneL[currentPoint].position, transform.position);

        transform.position = Vector3.Lerp(transform.position, laneL[currentPoint].position, Time.deltaTime * speed);

       


        if (dist <= reachDist)
        {
            currentPoint++;
        }



        if (currentPoint >= laneL.Length)
        {
            currentPoint = 0;
        }

    }


}
