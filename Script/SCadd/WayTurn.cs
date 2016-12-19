using UnityEngine;
using System.Collections;

public class WayTurn : MonoBehaviour {

    float check = 0;
    float checkWay = 0;
    float roteteSpeed = 2.5f;
    float turn = 0;
    float turn2 = 0;
    float turn3 = 0;

    bool turnGateD = false;
    bool turnGateT = false;
    bool turnGateR = false;
    bool turnGateL = false;

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



    public GravityCt sendBool;

    // Use this for initialization
    void Start()
    {
         check = 0;
         checkWay = 0;
         roteteSpeed = 2.5f;
         turn = 0;
         turn2 = 0;
         turn3 = 0;

         turnGateD = false;
         turnGateT = false;
         turnGateR = false;
         turnGateL = false;

         turnD = false;
         turnUp = false;
         turnL = false;
         turnR = false;
         turnL180 = false;
         turnR180 = false;
         turnSpin01 = false;
         turnSpin02 = false;
         turnSpin03 = false;
         turnSpin04 = false;
         turnSpin05 = false;
         turnSpin06 = false;
         turnSpin07 = false;
         turnSpin08 = false;
         turnSpin09 = false;
         turnCurve = false;
         turnCurve02 = false;
         turnCurve03 = false;
         turnCurve04 = false;
         turnCurve05 = false;
         turnCurve06 = false;

         turnTR = false;

         BugY = false;



    }

    // Update is called once per frame
    void Update()
    {
        if (turnCurve == true)
        {
            if (sendBool.BR == true)
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

            if (sendBool.BL == true)
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
            if (sendBool.BR == true)
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

            if (sendBool.BL == true)
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
            if (sendBool.BR == true)
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

            if (sendBool.BL == true)
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
            if (sendBool.BR == true)
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

            if (sendBool.BL == true)
            {
                if (turn < -0.2f)
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
            if (sendBool.BR == true)
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

            if (sendBool.BL == true)
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
            if (sendBool.BR == true)
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

            if (sendBool.BL == true)
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

        if (BugY == true)
        {
            if (sendBool.BR == true)
            {
                if (turn < 2.0f)
                {
                    turn += 0.1f;
                    transform.Rotate(0, turn, 0);
                    if (turn >= 2.0f)
                    {

                        turn = 0;
                        BugY = false;
                        sendBool.BR = false;
                    }

                }
            }
            if (sendBool.BL == true)
            {
                if (turn > -1.8f)
                {
                    turn -= 0.1f;
                    transform.Rotate(0, turn, 0);
                    if (turn <= -1.8f)
                    {

                        turn = 0;
                        BugY = false;
                        sendBool.BL = false;
                    }

                }
            }
        }



        if (turnR == true && turnL == false)
        {

            transform.Rotate(0, 0, turn + roteteSpeed);
            check += roteteSpeed;
            checkWay += roteteSpeed;
            if (check >= 90)
            {
                turnR = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }
            /*if (turn < 7.2f)
            {
                turn += 0.3f;
                transform.Rotate(0, 0, turn);
                if (turn >= 7.2f)
                {
                    turnR = false;
                    turn = 0;
                }
            }*/
        }

        if (turnL == true && turnR == false)
        {

            transform.Rotate(0, 0, turn - roteteSpeed);
            check -= roteteSpeed;
            checkWay -= roteteSpeed;
            if (check <= -90)
            {
                turnL = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }
            /* if (turn > -7.2f)
             {
                 turn -= 0.3f;
                 transform.Rotate(0, 0, turn);
                 if (turn <= -7.2f)
                 {
                     turnL = false;
                     turn = 0;
                 }
             }*/
        }

        if (turnL180 == true && turnR180 == false)
        {
            transform.Rotate(0, 0, turn - roteteSpeed);
            check -= roteteSpeed;
            checkWay -= roteteSpeed;
            if (check <= -180)
            {
                turnL180 = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }

            /* if (turn > -14.4f)
             {
                 turn -= 0.6f;
                 transform.Rotate(0, 0, turn);
                 if (turn <= -14.4f)
                 {
                     turnL180 = false;
                     turn = 0;
                 }
             }*/
        }

        if (turnR180 == true && turnL180 == false)
        {
            transform.Rotate(0, 0, turn + roteteSpeed);
            check += roteteSpeed;
            checkWay += roteteSpeed;
            if (check >= 180)
            {
                turnR180 = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }
            /* if (turn < 14.4f)
             {
                 turn += 0.6f;
                 transform.Rotate(0, 0, turn);
                 if (turn >= 14.4f)
                 {
                     turnR180 = false;
                     turn = 0;
                 }
             }*/
        }

        if (turnUp == true)
        {
            transform.Rotate(turn - roteteSpeed, 0, 0);
            check -= roteteSpeed;
            checkWay -= roteteSpeed;
            if (check <= -35)
            {
                turnUp = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }
            /*if (turn > -4.5f)
            {
                turn -= 0.3f;
                transform.Rotate(turn, 0, 0);
                if (turn <= -4.5f)
                {
                    turnUp = false;
                    turn = 0;
                }
            }*/
        }

        if (turnD == true)
        {
            transform.Rotate(turn + roteteSpeed, 0, 0);
            check += roteteSpeed;
            checkWay += roteteSpeed;
            if (check >= 35)
            {
                turnD = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }
            /* if (turn < 4.5f)
             {
                 turn += 0.3f;
                 transform.Rotate(turn, 0, 0);
                 if (turn >= 4.5f)
                 {
                     turnD = false;
                     turn = 0;
                 }
             }*/
        }

        if (turnSpin01 == true)
        {

            sendBool.Leftgravity = false;
            sendBool.Downgravity = true;
            sendBool.Rightgravity = false;
            sendBool.Topgravity = false;

            transform.Rotate(0, 0, turn + roteteSpeed);
            check += roteteSpeed;
            checkWay += roteteSpeed;
            if (check >= 20)
            {
                turnSpin01 = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }
            /* if (turn < 3.2f)
             {
                 turn += 0.3f;
                 transform.Rotate(0, 0, turn);
                 sendBool.Leftgravity = false;
                 sendBool.Downgravity = true;
                 sendBool.Rightgravity = false;
                 sendBool.Topgravity = false;
                 if (turn >= 3.2f)
                 {
                     turnSpin01 = false;
                     turn = 0;
                 }
             }*/



        }

        if (turnSpin02 == true)
        {
            sendBool.Leftgravity = false;
            sendBool.Downgravity = false;
            sendBool.Rightgravity = true;
            sendBool.Topgravity = false;

            transform.Rotate(0, 0, turn + roteteSpeed);
            check += roteteSpeed;
            checkWay += roteteSpeed;
            if (check >= 20)
            {
                turnSpin02 = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }
            /* if (turn < 3.2f)
             {
                 turn += 0.3f;
                 transform.Rotate(0, 0, turn);
                 sendBool.Leftgravity = false;
                 sendBool.Downgravity = false;
                 sendBool.Rightgravity = true;
                 sendBool.Topgravity = false;
                 if (turn >= 3.2f)
                 {
                     turnSpin02 = false;
                     turn = 0;
                 }
             }*/


        }

        if (turnSpin03 == true)
        {
            sendBool.Leftgravity = false;
            sendBool.Downgravity = false;
            sendBool.Rightgravity = true;
            sendBool.Topgravity = false;

            transform.Rotate(0, 0, turn + roteteSpeed);
            check += roteteSpeed;
            checkWay += roteteSpeed;
            if (check >= 20)
            {
                turnSpin03 = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }
            /*if (turn < 3.2f)
            {
                turn += 0.3f;
                transform.Rotate(0, 0, turn);
                sendBool.Leftgravity = false;
                sendBool.Downgravity = false;
                sendBool.Rightgravity = true;
                sendBool.Topgravity = false;
                if (turn >= 3.2f)
                {
                    turnSpin03 = false;
                    turn = 0;
                }
            }*/


        }

        if (turnSpin04 == true)
        {
            sendBool.Leftgravity = false;
            sendBool.Downgravity = false;
            sendBool.Rightgravity = true;
            sendBool.Topgravity = false;

            transform.Rotate(0, 0, turn + roteteSpeed);
            check += roteteSpeed;
            checkWay += roteteSpeed;
            if (check >= 20)
            {
                turnSpin04 = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }
            /* if (turn < 3.2f)
             {
                 turn += 0.3f;
                 transform.Rotate(0, 0, turn);
                 sendBool.Leftgravity = false;
                 sendBool.Downgravity = false;
                 sendBool.Rightgravity = true;
                 sendBool.Topgravity = false;
                 if (turn >= 3.2f)
                 {
                     turnSpin04 = false;
                     turn = 0;
                 }
             }*/


        }

        if (turnSpin05 == true)
        {
            sendBool.Leftgravity = false;
            sendBool.Downgravity = false;
            sendBool.Rightgravity = true;
            sendBool.Topgravity = false;

            transform.Rotate(0, 0, turn + roteteSpeed);
            check += roteteSpeed;
            checkWay += roteteSpeed;
            if (check >= 20)
            {
                turnSpin05 = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }
            /* if (turn < 3.2f)
             {
                 turn += 0.3f;
                 transform.Rotate(0, 0, turn);
                 sendBool.Leftgravity = false;
                 sendBool.Downgravity = false;
                 sendBool.Rightgravity = true;
                 sendBool.Topgravity = false;
                 if (turn >= 3.2f)
                 {
                     turnSpin05 = false;
                     turn = 0;
                 }
             }*/
        }

        if (turnSpin06 == true)
        {

            sendBool.Leftgravity = false;
            sendBool.Downgravity = false;
            sendBool.Rightgravity = false;
            sendBool.Topgravity = true;

            transform.Rotate(0, 0, turn + roteteSpeed);
            check += roteteSpeed;
            checkWay += roteteSpeed;
            if (check >= 20)
            {
                turnSpin06 = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }
            /* if (turn < 3.2f)
             {
                 turn += 0.3f;
                 transform.Rotate(0, 0, turn);
                 sendBool.Leftgravity = false;
                 sendBool.Downgravity = false;
                 sendBool.Rightgravity = false;
                 sendBool.Topgravity = true;
                 if (turn >= 3.2f)
                 {
                     turnSpin06 = false;
                     turn = 0;
                 }
             }*/
        }

        if (turnSpin07 == true)
        {

            sendBool.Leftgravity = false;
            sendBool.Downgravity = false;
            sendBool.Rightgravity = false;
            sendBool.Topgravity = true;

            transform.Rotate(0, 0, turn + roteteSpeed);
            check += roteteSpeed;
            checkWay += roteteSpeed;
            if (check >= 20)
            {
                turnSpin07 = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }
            /* if (turn < 3.2f)
             {
                 turn += 0.3f;
                 transform.Rotate(0, 0, turn);
                 sendBool.Leftgravity = false;
                 sendBool.Downgravity = false;
                 sendBool.Rightgravity = false;
                 sendBool.Topgravity = true;
                 if (turn >= 3.2f)
                 {
                     turnSpin07 = false;
                     turn = 0;
                 }
             }*/
        }

        if (turnSpin08 == true)
        {
            sendBool.Leftgravity = false;
            sendBool.Downgravity = false;
            sendBool.Rightgravity = false;
            sendBool.Topgravity = true;

            transform.Rotate(0, 0, turn + roteteSpeed);
            check += roteteSpeed;
            checkWay += roteteSpeed;
            if (check >= 20)
            {
                turnSpin08 = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }

            /*  if (turn < 3.2f)
              {
                  turn += 0.3f;
                  transform.Rotate(0, 0, turn);
                  sendBool.Leftgravity = false;
                  sendBool.Downgravity = false;
                  sendBool.Rightgravity = false;
                  sendBool.Topgravity = true;
                  if (turn >= 3.2f)
                  {
                      turnSpin08 = false;
                      turn = 0;
                  }
              }*/
        }

        if (turnSpin09 == true)
        {
            sendBool.Leftgravity = false;
            sendBool.Downgravity = false;
            sendBool.Rightgravity = false;
            sendBool.Topgravity = true;

            transform.Rotate(0, 0, turn + roteteSpeed);
            check += roteteSpeed;
            checkWay += roteteSpeed;
            if (check >= 20)
            {
                turnSpin09 = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }

            /* if (turn < 3.2f)
             {
                 turn += 0.3f;
                 transform.Rotate(0, 0, turn);
                 sendBool.Leftgravity = false;
                 sendBool.Downgravity = false;
                 sendBool.Rightgravity = false;
                 sendBool.Topgravity = true;
                 if (turn >= 3.2f)
                 {
                     turnSpin09 = false;
                     turn = 0;
                 }
             }*/
        }




    }

    void OnTriggerEnter(Collider checkTurn)
    {
        /// turn start 

        if (checkTurn.gameObject.tag == "turnR")
        {
            turnR = true;

        }


        if (checkTurn.gameObject.tag == "turnL")
        {
            turnL = true;

        }

        if (checkTurn.gameObject.tag == "turnL180")
        {
            turnL180 = true;

        }


        if (checkTurn.gameObject.tag == "turnR180")
        {
            turnR180 = true;

        }

        if (checkTurn.gameObject.tag == "turnUp")
        {
            turnUp = true;

        }

        if (checkTurn.gameObject.tag == "turnD")
        {
            turnD = true;

        }


        if (checkTurn.gameObject.tag == "turnSpin01")
        {
            turnSpin01 = true;

        }

        if (checkTurn.gameObject.tag == "turnSpin02")
        {
            turnSpin02 = true;

        }
        if (checkTurn.gameObject.tag == "turnSpin03")
        {
            turnSpin03 = true;

        }
        if (checkTurn.gameObject.tag == "turnSpin04")
        {
            turnSpin04 = true;

        }
        if (checkTurn.gameObject.tag == "turnSpin05")
        {
            turnSpin05 = true;

        }

        if (checkTurn.gameObject.tag == "turnSpin06")
        {
            turnSpin06 = true;

        }

        if (checkTurn.gameObject.tag == "turnSpin07")
        {
            turnSpin07 = true;

        }

        if (checkTurn.gameObject.tag == "turnSpin08")
        {
            turnSpin08 = true;

        }

        if (checkTurn.gameObject.tag == "turnSpin09")
        {
            turnSpin09 = true;

        }

        if (checkTurn.gameObject.tag == "turnC")
        {
            turnCurve = true;

        }

        if (checkTurn.gameObject.tag == "turnC02")
        {
            turnCurve02 = true;

        }

        if (checkTurn.gameObject.tag == "turnC03")
        {
            turnCurve03 = true;

        }

        if (checkTurn.gameObject.tag == "turnC04")
        {
            turnCurve04 = true;

        }

        if (checkTurn.gameObject.tag == "turnC05")
        {
            turnCurve05 = true;

        }

        if (checkTurn.gameObject.tag == "turnC06")
        {
            turnCurve06 = true;

        }

        if (checkTurn.gameObject.tag == "BugY")
        {
            BugY = true;

        }




        /// turn end
    }

    void OnTriggerExit(Collider other)
    {
        // Destroy everything that leaves the trigger
        Destroy(other.gameObject);
    }
}
