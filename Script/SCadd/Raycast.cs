using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Raycast : MonoBehaviour {

    public Transform LoadingBar;
    private float CA = 0;
    private float speed = 30 ;
    public bool CM = false;

    public GameObject door, vehicle, loading, cam2;
    
    
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        RCT();
    }

    void RCT()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;

        Debug.DrawRay(transform.position, forward , Color.green);

        if (Physics.Raycast(transform.position, (forward), out hit) == true)
        {
            if (hit.collider.tag == "PLAY")
            {
                Loading();
                if(CA >= 100)
                {
                    LoadScenes();
                }
                //Debug.Log("HIT : " + CA );
                
            }
            if (hit.collider.tag == "PRACTICE")
            {
                Loading();
                if (CA >= 100)
                {
                    LoadScenes2();
                }
                //Debug.Log("HIT : 2 ");
            }
            if (hit.collider.tag == "EXIT")
            {

                if (CA >= 100)
                {
                    LoadScenes5();
                }
                //LoadingBar.GetComponent<Image>().fillAmount = 0f;
               // CA = 0;
                //Debug.Log("HIT : 3 ");
            }
            //Debug.Log("HIT : " + hit.transform.gameObject.tag);

            if (hit.collider.tag == "MENU")
            {
                Loading();
                if (CA >= 100)
                {
                    LoadScenes3();
                }
            }

            if (hit.collider.tag == "RESUME")
            {
                Loading();
                if (CA >= 100)
                {
                    LoadScenes4();
                }

            }

        }

        if(Physics.Raycast(transform.position, (forward), out hit) == false)
        {
                LoadingBar.GetComponent<Image>().fillAmount = 0f;
                CA = 0;
        }
    }
    void Loading ()
    {
        if(CA < 100)
        {
            CA += speed * Time.deltaTime;
            LoadingBar.GetComponent<Image>().fillAmount = CA / 100;
           
        }
    }
    void LoadScenes()
    {
        CM = true;

        cam2.SetActive(true);
        door.GetComponent<Animator>().SetInteger("circle", 1);
        StartCoroutine(waiter1());

        Debug.Log("PLAY");
    }
    void LoadScenes2()
    {
        CM = true;
        cam2.SetActive(true);
        door.GetComponent<Animator>().SetInteger("circle", 1);
        StartCoroutine(waiter2());
        Debug.Log("PRACTICE");
    }

    void LoadScenes3() {
        CM = true;
        Application.LoadLevel("Menu");
    }

    void LoadScenes4()
    {
        CM = true;
        Application.LoadLevel("Play");
    }

    void LoadScenes5()
    {
        CM = true;
        Application.Quit();
    }

    IEnumerator waiter1() { 

        yield return new WaitForSeconds(2);
        vehicle.GetComponent<Animator>().SetInteger("moveVehicle", 1);

        yield return new WaitForSeconds(4.5f);
        loading.SetActive(true);

        yield return new WaitForSeconds(5);
        Application.LoadLevel("Play");
    }

    IEnumerator waiter2()
    {

        yield return new WaitForSeconds(2);
        vehicle.GetComponent<Animator>().SetInteger("moveVehicle", 1);

        yield return new WaitForSeconds(4.5f);
        loading.SetActive(true);

        yield return new WaitForSeconds(5);
        Application.LoadLevel("practice");
    }

}
