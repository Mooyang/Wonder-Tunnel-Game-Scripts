using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{
    float time;
    // Use this for initialization
    void Start()
    {
        time = Time.time * 0;
    }

    // Update is called once per frame
    void Update()
    {

        time = Time.time;

      /*  if (time >= 20000000)
        {
            Destroy(this.gameObject);
        }*/

    }
}
