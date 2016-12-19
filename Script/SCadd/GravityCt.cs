using UnityEngine;
using System.Collections;

public class GravityCt : MonoBehaviour {
    public Vector3 gravity;
    public bool Leftgravity = false;
    public bool Rightgravity = false;
    public bool Topgravity = false;
    public bool Downgravity = false;
    public bool DLgravity = false;
    public bool DRgravity = false;
    public bool TLgravity = false;
    public bool TRgravity = false;
    public bool Forgravity = false;
    public bool Backgravity = false;

    public bool BR = false;
    public bool BL = false;


    public SwapGT checkT;

    // Use this for initialization
    void Start()
    {
                 Leftgravity = false;
         Rightgravity = false;
         Topgravity = false;
        Downgravity = true;
         DLgravity = false;
        DRgravity = false;
             TLgravity = false;
             TRgravity = false;
               Forgravity = false;
             Backgravity = false;

             BR = false;
             BL = false;


    }

    // Update is called once per frame
    void Update()
    {
        /// gravity

        Physics.gravity = gravity;

        if (checkT.noG == true)
        {
            gravity.x = 0;
            gravity.y = 0;
            gravity.z = 0;
        }

        if (Downgravity == true && Topgravity == false)
        {
            gravity.x = 0;
            gravity.y = -100;
            gravity.z = 0;

        }

        if (Topgravity == true && Downgravity == false)
        {
            gravity.x = 0;
            gravity.y = 100;
            gravity.z = 0;
        }

        if (Leftgravity == true && Rightgravity == false)
        {
            gravity.x = -100;
            gravity.y = 0;
            gravity.z = 0;
        }

        if (Rightgravity == true && Leftgravity == false)
        {
            gravity.x = 100;
            gravity.y = 0;
            gravity.z = 0;
        }

        if (DLgravity == true)
        {
            if (BR == true)
            {
                gravity.x = -100;
                gravity.y = -100;
                gravity.z = 0;
            }

            if (BL == true)
            {
                gravity.x = 100;
                gravity.y = -100;
                gravity.z = 0;
            }

        }

        if (TLgravity == true)
        {
            if (BR == true)
            {
                gravity.x = -100;
                gravity.y = -100;
                gravity.z = 100;
            }

            if (BL == true)
            {
                gravity.x = 100;
                gravity.y = -100;
                gravity.z = 100;
            }

        }

        if (Forgravity == true)
        {
            gravity.x = 0;
            gravity.y = 0;
            gravity.z = 100;

        }

        if (Backgravity == true)
        {
            gravity.x = 0;
            gravity.y = 0;
            gravity.z = -100;

        }
    }

    void OnTriggerEnter(Collider checkGravity)
    {
        /// gravity boolean start

        if (checkGravity.gameObject.tag == "wayL")
        {
            Leftgravity = true;
            Downgravity = false;
            Rightgravity = false;
            Topgravity = false;
            DLgravity = false;
            DRgravity = false;
            TLgravity = false;
            TRgravity = false;
            Forgravity = false;
            Backgravity = false;

        }


        if (checkGravity.gameObject.tag == "wayR")
        {
            Leftgravity = false;
            Downgravity = false;
            Rightgravity = true;
            Topgravity = false;
            DLgravity = false;
            DRgravity = false;
            TLgravity = false;
            TRgravity = false;
            Forgravity = false;
            Backgravity = false;

        }

        if (checkGravity.gameObject.tag == "wayT")
        {
            Leftgravity = false;
            Downgravity = false;
            Rightgravity = false;
            Topgravity = true;
            DLgravity = false;
            DRgravity = false;
            TLgravity = false;
            TRgravity = false;
            Forgravity = false;
            Backgravity = false;

        }

        if (checkGravity.gameObject.tag == "wayD")
        {
            Leftgravity = false;
            Downgravity = true;
            Rightgravity = false;
            Topgravity = false;
            DLgravity = false;
            DRgravity = false;
            TLgravity = false;
            TRgravity = false;
            Forgravity = false;
            Backgravity = false;

        }

        if (checkGravity.gameObject.tag == "DLgravity")
        {
            Leftgravity = false;
            Downgravity = false;
            Rightgravity = false;
            Topgravity = false;
            DLgravity = true;
            DRgravity = false;
            TLgravity = false;
            TRgravity = false;
            Forgravity = false;
            Backgravity = false;

        }
        if (checkGravity.gameObject.tag == "DRgravity")
        {
            Leftgravity = false;
            Downgravity = false;
            Rightgravity = false;
            Topgravity = false;
            DLgravity = false;
            DRgravity = true;
            TLgravity = false;
            TRgravity = false;
            Forgravity = false;
            Backgravity = false;
        }
        if (checkGravity.gameObject.tag == "TLgravity")
        {
            Leftgravity = false;
            Downgravity = false;
            Rightgravity = false;
            Topgravity = false;
            DLgravity = false;
            DRgravity = false;
            TLgravity = true;
            TRgravity = false;
            Forgravity = false;
            Backgravity = false;
        }
        if (checkGravity.gameObject.tag == "TRgravity")
        {
            Leftgravity = false;
            Downgravity = false;
            Rightgravity = false;
            Topgravity = false;
            DLgravity = false;
            DRgravity = false;
            TLgravity = false;
            TRgravity = true;
            Forgravity = false;
            Backgravity = false;
        }

        if (checkGravity.gameObject.tag == "Forgravity")
        {
            Leftgravity = false;
            Downgravity = false;
            Rightgravity = false;
            Topgravity = false;
            DLgravity = false;
            DRgravity = false;
            TLgravity = false;
            TRgravity = false;
            Forgravity = true;
            Backgravity = false;
        }

        if (checkGravity.gameObject.tag == "Backgravity")
        {
            Leftgravity = false;
            Downgravity = false;
            Rightgravity = false;
            Topgravity = false;
            DLgravity = false;
            DRgravity = false;
            TLgravity = false;
            TRgravity = false;
            Forgravity = false;
            Backgravity = true;
        }
        /// gravity boolean end
        /// 
        if (checkGravity.gameObject.tag == "BR")
        {
            BR = true;

        }

        if (checkGravity.gameObject.tag == "BL")
        {
            BL = true;

        }
    }

}
