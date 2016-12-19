using UnityEngine;
using System.Collections;

public class SwapGW : MonoBehaviour {

    public TunnelControl sendW;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "checkGW")
        {

            sendW.way = true;
            sendW.tunnel = false;
        }
    }
}
