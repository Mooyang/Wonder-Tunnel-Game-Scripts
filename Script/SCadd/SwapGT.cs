using UnityEngine;
using System.Collections;

public class SwapGT : MonoBehaviour {

    public bool noG = false;

    public GravityCt Gc;
    public TunnelControl checkControl;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "checkGT")
        {

            noG = true;
            Gc.Leftgravity = false;
            Gc.Downgravity = false;
            Gc.Rightgravity = false;
            Gc.Topgravity = false;
            checkControl.tunnel = true;
            checkControl.way = false;
        }

        if (other.gameObject.name == "nextTunnel")
        {
            checkControl.nextTunnel = true;
        }
        else checkControl.nextTunnel = false;


    }
}
