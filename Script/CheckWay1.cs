using UnityEngine;
using System.Collections;

public class CheckWay1 : MonoBehaviour {

    public GameObject[] prefabHard;
    public GameObject[] prefabNormal;
    public GameObject[] prefabEasy;
    public Transform[] spawnPoints;
    public int Create = 0;
    public TunnelControl sendTC;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player")
        {
            Spawn();
            print("way");
            
        }
    }

    void Spawn()
    {

        int spawnIndexs = Random.Range(0, spawnPoints.Length);
        Create = Random.Range(1, 3);
        if (Create == 1)
        {
            int tunnelIndexs = Random.Range(0, prefabEasy.Length);
            Instantiate(prefabEasy[tunnelIndexs], spawnPoints[spawnIndexs].position, spawnPoints[spawnIndexs].rotation);
        }
        if (Create == 2)
        {
            int tunnelIndexs2 = Random.Range(0, prefabNormal.Length);
            Instantiate(prefabNormal[tunnelIndexs2], spawnPoints[spawnIndexs].position, spawnPoints[spawnIndexs].rotation);
        }
        if (Create == 3)
        {
            int tunnelIndexs3 = Random.Range(0, prefabHard.Length);
            Instantiate(prefabHard[tunnelIndexs3], spawnPoints[spawnIndexs].position, spawnPoints[spawnIndexs].rotation);
        }


    }
}
