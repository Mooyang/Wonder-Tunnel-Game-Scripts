using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {

    public control Controlcheck;

    Vector3 gravity;
    bool Leftgravity = false;
    bool Rightgravity = false;
    bool Topgravity = false;
    bool Downgravity = true;
    bool DLgravity = false;
    bool DRgravity = false;
    bool TLgravity = false;
    bool TRgravity = false;
    bool Forgravity = false;
    bool Backgravity = false;

    public bool speedUp = false;
    float turn = 0;
    float turn2 = 0;
    float turn3 = 0;

    bool turnGateD = false;
    bool turnGateT = false;
    bool turnGateR = false;
    bool turnGateL = false;

    public bool checkSP = false;

    bool turnD = false;
    bool turnUp = false;
    bool turnL = false;
    bool turnR = false;
    bool turnL180 = false;
    bool turnR180 = false;
    bool turnSpin01 = false;
    bool turnSpin02 = false;
    bool turnSpin03 = false;
    bool turnSpin04 = false;
    bool turnSpin05 = false;
    bool turnSpin06 = false;
    bool turnSpin07 = false;
    bool turnSpin08 = false;
    bool turnSpin09 = false;
    bool turnCurve = false;
    bool turnCurve02 = false;
    bool turnCurve03 = false;
    bool turnCurve04 = false;
    bool turnCurve05 = false;
    bool turnCurve06 = false;

    bool turnTR = false;

    bool BugY = false;
    bool BR = false;
    bool BL = false;


    public static float sp;
	public static int maxSp;
	public GameObject pauseUI;
	private GameObject hander;
	Animator anim;
	public AudioClip soundMove;
	AudioSource source1;
	Rigidbody rb;

	void Start () {

		sp = 100;
		maxSp = 200;
		anim = GetComponent<Animator>();
		source1 = GetComponent<AudioSource> ();
		rb = GetComponent<Rigidbody> ();
		pauseUI.SetActive (false);

	}

    void Update() {

        Debug.Log("HP" + sp);
        Debug.Log("Speed" + sp);

        if (HpBar.hpScore <= 0 || TimeScore.Score <= 0) {

            	rb.constraints = RigidbodyConstraints.FreezeAll;
        }


        if (HpBar.hpScore > 0 && TimeScore.Score > 0) {

            if (sp < 50)
                sp = 50;

            if (sp > 250)
                sp = 250;


			transform.Translate(0, 0, sp * Time.deltaTime);
			if (sp < maxSp) 
				sp += .2f;

            if (EnergyBar.energyScore > 0) {
                if (Input.GetKey(KeyCode.Space)) {

					gravity.y = 0;
                    EnergyBar.energyScore -= 0.01f;
                    transform.Translate(0, sp * Time.deltaTime, 0);
                }
            }

            if (Input.GetKey(KeyCode.UpArrow)) {

                transform.Translate(0, 0, sp * Time.deltaTime);
                if (sp < maxSp) {
                    sp += .2f;
                }
            }

            if (Input.GetKey(KeyCode.DownArrow)) {

                transform.Translate(0, 0, -sp * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.RightArrow)) {

                transform.Translate(sp * Time.deltaTime, 0, 0);
				anim.SetInteger ("hander2", 1);
            } else
				anim.SetInteger ("hander2", 0);

            if (Input.GetKey(KeyCode.LeftArrow)) {

                transform.Translate(-sp * Time.deltaTime, 0, 0);
				anim.SetInteger ("hander", 1);

            } else
				anim.SetInteger ("hander", 0);

        }

        /// gravity

        Physics.gravity = gravity;



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
            if(BR == true)
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
            if(BR == true)
            {
                gravity.x = -100;
                gravity.y = -100;
                gravity.z = 100;
            }

            if(BL == true)
            {
                gravity.x = 100;
                gravity.y = -100;
                gravity.z = 100;
            }

        }

        if(Forgravity == true)
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

        if (turnCurve == true)
        {
            if(BR == true)
            {
                if (turn > -2.4f)
                {
                    turn -= 0.1f;
                    transform.Rotate(0, 0, turn);
                    if (turn <= -2.4f)
                    {
                        turn = 0;
                        turnCurve = false;
                    }

                }

                if (turn2 < 1.2f)
                {
                    turn2 += 0.1f;
                    transform.Rotate(0, turn2, 0);
                    if (turn2 >= 1.2f)
                    {
                        turn2 = 0;
                    }
                }
            }

            if (BL == true)
            {
                if (turn < 2.4f)
                {
                    turn += 0.1f;
                    transform.Rotate(0, 0, turn);
                    if (turn >= 2.4f)
                    {
                        turn = 0;
                        turnCurve = false;
                    }

                }

                if (turn2 > -1.2f)
                {
                    turn2 -= 0.1f;
                    transform.Rotate(0, turn2, 0);
                    if (turn2 <= -1.2f)
                    {
                        turn2 = 0;
                    }
                }
            }


        }

        if (turnCurve02 == true)
        {
            if(BR == true)
            {
                if (turn > -2.2f)
                {
                    turn -= 0.1f;
                    transform.Rotate(0, 0, turn);
                    if (turn <= -2.2f)
                    {
                        turn = 0;
                        turnCurve02 = false;
                    }

                }

                if (turn2 < 1.0f)
                {
                    turn2 += 0.1f;
                    transform.Rotate(0, turn2, 0);
                    if (turn2 >= 1.0f)
                    {
                        turn2 = 0;
                    }
                }
            }

            if (BL == true)
            {
                if (turn < 2.2f)
                {
                    turn += 0.1f;
                    transform.Rotate(0, 0, turn);
                    if (turn >= 2.2f)
                    {
                        turn = 0;
                        turnCurve02 = false;
                    }

                }

                if (turn2 > -1.0f)
                {
                    turn2 -= 0.1f;
                    transform.Rotate(0, turn2, 0);
                    if (turn2 <= -1.0f)
                    {
                        turn2 = 0;
                    }
                }
            }


        }

        if (turnCurve03 == true)
        {
            if(BR == true)
            {
                if (turn > -1.0f)
                {
                    turn -= 0.1f;
                    transform.Rotate(0, 0, turn);
                    if (turn <= -1.0f)
                    {
                        turn = 0;

                    }

                }

                if (turn2 < 1.4f)
                {
                    turn2 += 0.1f;
                    transform.Rotate(0, turn2, 0);
                    if (turn2 >= 1.4f)
                    {
                        turn2 = 0;

                    }
                }

                if (turn3 > -2.2f)
                {
                    turn3 -= 0.1f;
                    transform.Rotate(turn3, 0, 0);
                    if (turn3 <= -2.2f)
                    {
                        turn3 = 0;
                        turnCurve03 = false;
                    }
                }
            }

            if (BL == true)
            {
                if (turn < 1.0f)
                {
                    turn += 0.1f;
                    transform.Rotate(0, 0, turn);
                    if (turn >= 1.0f)
                    {
                        turn = 0;

                    }

                }

                if (turn2 > -1.4f)
                {
                    turn2 -= 0.1f;
                    transform.Rotate(0, turn2, 0);
                    if (turn2 <= -1.4f)
                    {
                        turn2 = 0;

                    }
                }

                if (turn3 > -2.2f)
                {
                    turn3 -= 0.1f;
                    transform.Rotate(turn3, 0, 0);
                    if (turn3 <= -2.2f)
                    {
                        turn3 = 0;
                        turnCurve03 = false;
                    }
                }
            }

        }

        if (turnCurve04 == true)
        {
            if(BR == true)
            {
                if (turn > -0.8f)
                {
                    turn -= 0.1f;
                    transform.Rotate(0, 0, turn);
                    if (turn <= -0.8f)
                    {
                        turn = 0;

                    }

                }

                if (turn2 > -1.8f)
                {
                    turn2 -= 0.1f;
                    transform.Rotate(0, turn2, 0);
                    if (turn2 <= -1.8f)
                    {
                        turn2 = 0;
                        turnCurve04 = false;
                    }
                }

                if (turn3 > -0.2f)
                {
                    turn3 -= 0.1f;
                    transform.Rotate(turn3, 0, 0);
                    if (turn3 <= -0.2f)
                    {
                        turn3 = 0;

                    }
                }
            }

            if (BL == true)
            {
                if (turn <-0.2f)
                {
                    turn += 0.1f;
                    transform.Rotate(0, 0, turn);
                    if (turn >= 0.2f)
                    {
                        turn = 0;

                    }

                }

                if (turn2 < 1.8f)
                {
                    turn2 += 0.1f;
                    transform.Rotate(0, turn2, 0);
                    if (turn2 >= 1.8f)
                    {
                        turn2 = 0;
                        turnCurve04 = false;
                    }
                }

                if (turn3 > -0.2f)
                {
                    turn3 -= 0.1f;
                    transform.Rotate(turn3, 0, 0);
                    if (turn3 <= -0.2f)
                    {
                        turn3 = 0;

                    }
                }
            }

        }

        if (turnCurve05 == true)
        {
            if(BR == true)
            {
                if (turn > -1.9f)
                {
                    turn -= 0.1f;
                    transform.Rotate(0, 0, turn);
                    if (turn <= -1.9f)
                    {
                        turn = 0;
                        turnCurve05 = false;

                    }

                }

                if (turn2 < 1.8f)
                {
                    turn2 += 0.1f;
                    transform.Rotate(0, turn2, 0);
                    if (turn2 >= 1.8f)
                    {
                        turn2 = 0;

                    }
                }


                if (turn3 > -1.6f)
                {
                    turn3 -= 0.1f;
                    transform.Rotate(turn3, 0, 0);
                    if (turn3 <= -1.6f)
                    {
                        turn3 = 0;

                    }
                }
            }

            if (BL == true)
            {
                if (turn < 1.9f)
                {
                    turn += 0.1f;
                    transform.Rotate(0, 0, turn);
                    if (turn >= 1.9f)
                    {
                        turn = 0;
                        turnCurve05 = false;

                    }

                }

                if (turn2 > -1.8f)
                {
                    turn2 -= 0.1f;
                    transform.Rotate(0, turn2, 0);
                    if (turn2 <= -1.8f)
                    {
                        turn2 = 0;

                    }
                }


                if (turn3 > -1.6f)
                {
                    turn3 -= 0.1f;
                    transform.Rotate(turn3, 0, 0);
                    if (turn3 <= -1.6f)
                    {
                        turn3 = 0;

                    }
                }
            }
        }

        if (turnCurve06 == true)
        {
            if(BR == true)
            {
                if (turn < 6.93f)
                {
                    turn += 0.3f;
                    transform.Rotate(0, 0, turn);
                    if (turn >= 6.93f)
                    {

                        turn = 0;
                        turnCurve06 = false;
                    }

                }

                if (turn2 > -2.0f)
                {
                    turn2 -= 0.3f;
                    transform.Rotate(turn2, 0, 0);
                    if (turn <= -2.0f)
                    {

                        turn2 = 0;
                    }

                }
            }

            if (BL == true)
            {

                if (turn > -6.6f)
                {
                    turn -= 0.3f;
                    transform.Rotate(0, 0, turn);
                    if (turn <= -6.6f)
                    {
                        turnCurve06 = false;
                        turn = 0;
                    }
                }

                if (turn2 > -2.0f)
                {
                    turn2 -= 0.3f;
                    transform.Rotate(turn2, 0, 0);
                    if (turn <= -2.0f)
                    {

                        turn2 = 0;
                    }

                }
            }

        }

        if(BugY == true)
        {
            if(BR == true)
            {
                if (turn < 2.0f)
                {
                    turn += 0.1f;
                    transform.Rotate(0, turn, 0);
                    if (turn >= 2.0f)
                    {

                        turn = 0;
                        BugY = false;
                        BR = false;
                    }

                }
            }
            if (BL == true)
            {
                if (turn > -1.8f)
                {
                    turn -= 0.1f;
                    transform.Rotate(0, turn, 0);
                    if (turn <= -1.8f)
                    {

                        turn = 0;
                        BugY = false;
                        BL = false;
                    }

                }
            }
        }



        if (turnR == true && turnL == false)
        {
            if (turn < 7.2f)
            {
                turn += 0.3f;
                transform.Rotate(0, 0, turn);
                if (turn >= 7.2f)
                {
                    turnR = false;
                    turn = 0;
                }
            }
        }

        if (turnL == true && turnR == false)
        {
            if (turn > -7.2f)
            {
                turn -= 0.3f;
                transform.Rotate(0, 0, turn);
                if (turn <= -7.2f)
                {
                    turnL = false;
                    turn = 0;
                }
            }
        }

        if (turnL180 == true && turnR180 == false)
        {
            if (turn > -14.4f)
            {
                turn -= 0.6f;
                transform.Rotate(0, 0, turn);
                if (turn <= -14.4f)
                {
                    turnL180 = false;
                    turn = 0;
                }
            }
        }

        if (turnR180 == true && turnL180 == false)
        {
            if (turn < 14.4f)
            {
                turn += 0.6f;
                transform.Rotate(0, 0, turn);
                if (turn >= 14.4f)
                {
                    turnR180 = false;
                    turn = 0;
                }
            }
        }

        if (turnUp == true)
        {
            if (turn > -4.5f)
            {
                turn -= 0.3f;
                transform.Rotate(turn, 0, 0);
                if (turn <= -4.5f)
                {
                    turnUp = false;
                    turn = 0;
                }
            }
        }

        if (turnD == true)
        {
            if (turn < 4.5f)
            {
                turn += 0.3f;
                transform.Rotate(turn, 0, 0);
                if (turn >= 4.5f)
                {
                    turnD = false;
                    turn = 0;
                }
            }
        }

        if (turnSpin01 == true)
        {
            if (turn < 3.2f)
            {
                turn += 0.3f;
                transform.Rotate(0, 0, turn);
                Leftgravity = false;
                Downgravity = true;
                Rightgravity = false;
                Topgravity = false;
                if (turn >= 3.2f)
                {
                    turnSpin01 = false;
                    turn = 0;
                }
            }



        }

        if (turnSpin02 == true)
        {

            if (turn < 3.2f)
            {
                turn += 0.3f;
                transform.Rotate(0, 0, turn);
                Leftgravity = false;
                Downgravity = false;
                Rightgravity = true;
                Topgravity = false;
                if (turn >= 3.2f)
                {
                    turnSpin02 = false;
                    turn = 0;
                }
            }


        }

        if (turnSpin03 == true)
        {

            if (turn < 3.2f)
            {
                turn += 0.3f;
                transform.Rotate(0, 0, turn);
                Leftgravity = false;
                Downgravity = false;
                Rightgravity = true;
                Topgravity = false;
                if (turn >= 3.2f)
                {
                    turnSpin03 = false;
                    turn = 0;
                }
            }


        }

        if (turnSpin04 == true)
        {

            if (turn < 3.2f)
            {
                turn += 0.3f;
                transform.Rotate(0, 0, turn);
                Leftgravity = false;
                Downgravity = false;
                Rightgravity = true;
                Topgravity = false;
                if (turn >= 3.2f)
                {
                    turnSpin04 = false;
                    turn = 0;
                }
            }


        }

        if (turnSpin05 == true)
        {

            if (turn < 3.2f)
            {
                turn += 0.3f;
                transform.Rotate(0, 0, turn);
                Leftgravity = false;
                Downgravity = false;
                Rightgravity = true;
                Topgravity = false;
                if (turn >= 3.2f)
                {
                    turnSpin05 = false;
                    turn = 0;
                }
            }
        }

        if (turnSpin06 == true)
        {

            if (turn < 3.2f)
            {
                turn += 0.3f;
                transform.Rotate(0, 0, turn);
                Leftgravity = false;
                Downgravity = false;
                Rightgravity = false;
                Topgravity = true;
                if (turn >= 3.2f)
                {
                    turnSpin06 = false;
                    turn = 0;
                }
            }
        }

        if (turnSpin07 == true)
        {

            if (turn < 3.2f)
            {
                turn += 0.3f;
                transform.Rotate(0, 0, turn);
                Leftgravity = false;
                Downgravity = false;
                Rightgravity = false;
                Topgravity = true;
                if (turn >= 3.2f)
                {
                    turnSpin07 = false;
                    turn = 0;
                }
            }
        }

        if (turnSpin08 == true)
        {

            if (turn < 3.2f)
            {
                turn += 0.3f;
                transform.Rotate(0, 0, turn);
                Leftgravity = false;
                Downgravity = false;
                Rightgravity = false;
                Topgravity = true;
                if (turn >= 3.2f)
                {
                    turnSpin08 = false;
                    turn = 0;
                }
            }
        }

        if (turnSpin09 == true)
        {

            if (turn < 3.2f)
            {
                turn += 0.3f;
                transform.Rotate(0, 0, turn);
                Leftgravity = false;
                Downgravity = false;
                Rightgravity = false;
                Topgravity = true;
                if (turn >= 3.2f)
                {
                    turnSpin09 = false;
                    turn = 0;
                }
            }
        }




        /// end gravity

    }


    void OnTriggerEnter(Collider checkWay)
    {
        /// gravity boolean start

        if (checkWay.gameObject.tag == "wayL")
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


        if (checkWay.gameObject.tag == "wayR")
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

        if (checkWay.gameObject.tag == "wayT")
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

        if (checkWay.gameObject.tag == "wayD")
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

        if (checkWay.gameObject.tag == "DLgravity")
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
        if (checkWay.gameObject.tag == "DRgravity")
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
        if (checkWay.gameObject.tag == "TLgravity")
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
        if (checkWay.gameObject.tag == "TRgravity")
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

        if (checkWay.gameObject.tag == "Forgravity")
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

        if (checkWay.gameObject.tag == "Backgravity")
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


        /// turn start 

        if (checkWay.gameObject.tag == "turnR")
        {
            turnR = true;

        }


        if (checkWay.gameObject.tag == "turnL")
        {
            turnL = true;

        }

        if (checkWay.gameObject.tag == "turnL180")
        {
            turnL180 = true;

        }


        if (checkWay.gameObject.tag == "turnR180")
        {
            turnR180 = true;

        }

        if (checkWay.gameObject.tag == "turnUp")
        {
            turnUp = true;

        }

        if (checkWay.gameObject.tag == "turnD")
        {
            turnD = true;

        }


        if (checkWay.gameObject.tag == "turnSpin01")
        {
            turnSpin01 = true;

        }

        if (checkWay.gameObject.tag == "turnSpin02")
        {
            turnSpin02 = true;

        }
        if (checkWay.gameObject.tag == "turnSpin03")
        {
            turnSpin03 = true;

        }
        if (checkWay.gameObject.tag == "turnSpin04")
        {
            turnSpin04 = true;

        }
        if (checkWay.gameObject.tag == "turnSpin05")
        {
            turnSpin05 = true;

        }

        if (checkWay.gameObject.tag == "turnSpin06")
        {
            turnSpin06 = true;

        }

        if (checkWay.gameObject.tag == "turnSpin07")
        {
            turnSpin07 = true;

        }

        if (checkWay.gameObject.tag == "turnSpin08")
        {
            turnSpin08 = true;

        }

        if (checkWay.gameObject.tag == "turnSpin09")
        {
            turnSpin09 = true;

        }

        if (checkWay.gameObject.tag == "turnC")
        {
            turnCurve = true;

        }

        if (checkWay.gameObject.tag == "turnC02")
        {
            turnCurve02 = true;

        }

        if (checkWay.gameObject.tag == "turnC03")
        {
            turnCurve03 = true;

        }

        if (checkWay.gameObject.tag == "turnC04")
        {
            turnCurve04 = true;

        }

        if (checkWay.gameObject.tag == "turnC05")
        {
            turnCurve05 = true;

        }

        if (checkWay.gameObject.tag == "turnC06")
        {
            turnCurve06 = true;

        }

        if (checkWay.gameObject.tag == "BugY")
        {
            BugY = true;

        }

        if (checkWay.gameObject.tag == "BR")
        {
            BR = true;

        }

        if (checkWay.gameObject.tag == "BL")
        {
            BL = true;

        }

        /// turn end

    }



}
