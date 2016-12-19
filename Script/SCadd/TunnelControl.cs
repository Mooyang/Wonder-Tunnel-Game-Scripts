using UnityEngine;
using System.Collections;

public class TunnelControl : MonoBehaviour {

    float rotate = 0;
    float speed = 8f;
    float roteteSpeed = 10f;
    float totateSpeed = 10f;
    float check = 0;
    float checkTunnel = 0;
    float checkRoY = 0;

    public bool RoL = false;
    public bool RoR = false;
    public bool turnOn = false;

    bool turnTLR01 = false;
    bool turnTLR02 = false;

    public bool way = false;
    public bool tunnel = false;
    public bool nextTunnel = false;

    //Detect UI
    public GameObject Red, Blue, Danger, Warning, ArrowR, ArrowL, Speeder;
    public static bool red;
    public static bool blue;
    public static bool danger;
    public static bool warning;
    public static bool arrowR;
    public static bool arrowL;
    public static bool speeder;

    public bool slipL;
    public bool slipR;

    public CrashCheck1 camShake;

    public static float sp;
    public static int maxSp;
    public GameObject pauseUI;
    private GameObject hander;
    Animator anim;
    public AudioClip soundMove;
    AudioSource source1;
    Rigidbody rb;

    public AudioSource sourceSliper;
    public float timeCre;

    // Use this for initialization
    void Start () {

        Red.SetActive(false);
        Blue.SetActive(false);
        Danger.SetActive(false);
        Warning.SetActive(false);
        ArrowL.SetActive(false);
        ArrowR.SetActive(false);
        Speeder.SetActive(false);

        red = false;
        blue = false;
        danger = false;
        warning = false;
        arrowR = false;
        arrowL = false;
        speeder = false;

        slipR = false;
        slipL = false;
        nextTunnel = false;
        tunnel = false;
        way = false;
        RoL = false;
        RoR = false;
        rotate = 0;
        speed = 2f;
        roteteSpeed = 10f;
         totateSpeed = 10f;
         check = 0;
         checkTunnel = 0;
         checkRoY = 0;
        timeCre = 0;
        sp = 10;
        maxSp = 200;
        anim = GetComponent<Animator>();
        source1 = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();


    }

    public void Detecter()
    {

        if (red == true)
        {
            Red.SetActive(true);
             //camShake.cameraShake();
            StartCoroutine(close());
        }

        if (blue == true)
        {
            Blue.SetActive(true);
             //camShake.cameraShake();
            StartCoroutine(close());
        }

        if (danger == true)
        {
            Danger.SetActive(true);
            StartCoroutine(close());

        }

        if (warning == true)
        {
            Warning.SetActive(true);
            StartCoroutine(close());
        }

        if (arrowL == true)
        {
            ArrowL.SetActive(true);
            StartCoroutine(close());
        }

        if (arrowR == true)
        {
            ArrowR.SetActive(true);
            StartCoroutine(close());
        }

        if (speeder == true)
        {
            Speeder.SetActive(true);
            StartCoroutine(close());
        }



        if (red == false)
        {
            Red.SetActive(false);
         
        }

        if (blue == false)
        {
            Blue.SetActive(false);
        
        }

        if (danger == false)
        {
            Danger.SetActive(false);

        }

        if (warning == false)
        {
            Warning.SetActive(false);
        }

        if (arrowL == false)
        {
            ArrowL.SetActive(false);
        }

        if (arrowR == false)
        {
            ArrowR.SetActive(false);
        }
        if (speeder == false)
        {
            Speeder.SetActive(false);
        }
    }

    IEnumerator close() {

        yield return new WaitForSeconds(.5f);
        red = false;

        yield return new WaitForSeconds(1.5f);
        warning = false;
        blue = false;
        danger = false;
        arrowL = false;
        arrowR = false;

        yield return new WaitForSeconds(3f);
        speeder = false;

    }

        
        

        // Update is called once per frame
        void Update () {

        timeCre += Time.deltaTime;
        Debug.Log(timeCre);

        if(Input.GetKeyDown(KeyCode.O))
        {
            Application.LoadLevel("Play");
        }

        Detecter();

        if (HpBar.hpScore <= 0 || TimeScore.Score <= 0)
        {

            rb.constraints = RigidbodyConstraints.FreezeAll;
        }

        if (HpBar.hpScore > 0 && TimeScore.Score > 0)
        {

            if (sp < 50)
                sp = 50;

            if (sp > 250)
                sp = 250;


            transform.Translate(0, 0, sp * Time.deltaTime*2);
            if (sp < maxSp)
             sp += .05f;

            if (EnergyBar.energyScore > 0)
            {
                if (Input.GetKey(KeyCode.Space))
                {

                    EnergyBar.energyScore -= 0.01f;
                    transform.Translate(0, sp * Time.deltaTime, 0);
                }
            }


           if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(0, 0, speed/2 + Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(0, 0, -speed - Time.deltaTime);
            }
            TunnelMove();
            WayMove();

          /*  if(slipR == true)
            {
                    sourceSliper.Play();
                    transform.Translate (30 , 0, 0);


            }*/

          /*  if (slipL == true)
            {
                    sourceSliper.Play();
                    transform.Translate(-30, 0, 0);


            }*/

            if (way == true)
            {


                if (checkTunnel != 0)
                {
                    turnOn = true;
                    Rotate();
                }
            }

            if (nextTunnel == true)
            {


                if (checkTunnel != 0)
                {
                    turnOn = true;
                    Rotate();
                }
            }
        }

    }

    void TunnelMove()
    {

        if (tunnel == true)
        {
            Rotate();

            // Debug.Log(checkRoY);
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
               // transform.Rotate(0, 0, -speed + 1);
               // checkTunnel -= speed - 1;
                Debug.Log(checkTunnel);
                 RoL = true;
                //  Debug.Log("ROL" + RoL);
                   RoR = false;

            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
               // transform.Rotate(0, 0, speed + 1);
               // checkTunnel += speed + 1;
                //Debug.Log(checkTunnel);
                  RoR = true;
                //  Debug.Log("ROR"+RoR);
                  RoL = false;
            }

            /*   if (sendMa.chon == true)
               {
                   Rotate();
                   sendMa.chon = false;
               }*/

            /*  if (sendMa2.chon == true)
              {
                  Rotate();
                  sendMa2.chon = false;
              }*/

        }
    }


    void WayMove()
    {
        if(way == true)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {

                transform.Translate(speed + Time.deltaTime, 0, 0);
                //anim.SetInteger("hander2", 1);
            }
           /* else
                anim.SetInteger("hander2", 0);*/

            if (Input.GetKey(KeyCode.LeftArrow))
            {

                transform.Translate(-speed + Time.deltaTime, 0, 0);
               // anim.SetInteger("hander", 1);

            }
           /* else
                anim.SetInteger("hander", 0);*/
        }
    }

    void Rotate()
    {
        if (RoL == true)
        {
            //transform.rotation = Quaternion.Lerp(from.rotation , to.rotation, Time.time * -speed);
            transform.Rotate(0, 0, rotate - roteteSpeed);
            check -= roteteSpeed;
            checkTunnel -= roteteSpeed;
            if (check <= -45)
            {
                RoL = false;
                check = 0;
                //  Debug.Log("ROL"+RoL);
            }
        }

        if (RoR == true)
        {
            transform.Rotate(0, 0, rotate + roteteSpeed);
            check += roteteSpeed;
            checkTunnel += roteteSpeed;
            if (check >= 45)
            {
                RoR = false;
                check = 0;
                // Debug.Log("ROR" + RoR);

            }
        }

        if (turnOn == true)
        {
            Debug.Log(checkTunnel);
            roteteSpeed = 5f;
            if (checkTunnel > 0)
            {
                transform.Rotate(0, 0, rotate - roteteSpeed);
                checkTunnel -= roteteSpeed;
                if (checkTunnel == 0)
                {
                    turnOn = false;
                    checkTunnel = 0;
                    roteteSpeed = 2.5f;
                }
            }

            if (checkTunnel < 0)
            {
                transform.Rotate(0, 0, rotate + roteteSpeed);
                checkTunnel += roteteSpeed;
                if (checkTunnel == 0)
                {
                    turnOn = false;
                    checkTunnel = 0;
                    roteteSpeed = 2.5f;
                }
            }
        }

        if (turnTLR01 == true)
        {
            if (checkRoY > -17.5f)
            {
                transform.Rotate(0, rotate - totateSpeed, 0);
                checkRoY -= totateSpeed;
            }

        }

        if (turnTLR02 == true)
        {
            if (checkRoY > -17.5f)
            {
                transform.Rotate(0, rotate - totateSpeed, 0);
                checkRoY -= totateSpeed;
            }

        }


    }

    void OnTriggerEnter(Collider TunnelCheck)
    {
        if (TunnelCheck.gameObject.tag == "TLR01")
        {
            turnTLR01 = true;
        }
        if (TunnelCheck.gameObject.tag == "TLR02")
        {
            turnTLR02 = true;
            turnTLR01 = false;
        }

        if(TunnelCheck.gameObject.tag == "SlipperL")
        {
            slipL = true;
        }

        if (TunnelCheck.gameObject.tag == "SlipperR") {
            slipR = true;
        }


    }





}
