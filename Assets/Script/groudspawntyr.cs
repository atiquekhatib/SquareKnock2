using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groudspawntyr : MonoBehaviour
{
[SerializeField]
    private GameObject[] groundReference;

    public GameObject spawnedGround;

    [SerializeField]
    private Transform lPos, ldPos, luPos, rPos, rdPos, ruPos, cuPos, cdPos;

    private int randomIndex,randomSide;
    void Start()
    {
        StartCoroutine(SpawnGround());
    }

    IEnumerator SpawnGround()
    {
        while(true)
        {
        yield return new WaitForSeconds(Random.Range(3,4));
        randomIndex = Random.Range(0,groundReference.Length);
        randomSide = Random.Range(0,8);

        spawnedGround = Instantiate(groundReference[randomIndex]);
    
        if(randomSide == 0)
        {
            lPos = spawnedGround.transform.GetChild(0);
            //spawnedGround.transform.position = lPos.position;
        }

        else if(randomSide == 1)
        {
            ldPos = spawnedGround.transform.GetChild(1);
            //spawnedGround.transform.position = ldPos.position;
        }

        else if(randomSide == 2)
        {
            luPos = spawnedGround.transform.GetChild(2);
            //spawnedGround.transform.position = luPos.position;
        }

        else if(randomSide == 3)
        {
            rPos = spawnedGround.transform.GetChild(3);
            //spawnedGround.transform.position = rPos.position;
        }

        else if(randomSide == 4)
        {
            rdPos = spawnedGround.transform.GetChild(4);
            //spawnedGround.transform.position = rdPos.position;
        }

        else if(randomSide == 5)
        {
            ruPos = spawnedGround.transform.GetChild(5);
            //spawnedGround.transform.position = ruPos.position;
        }

        else if(randomSide == 6)
        {
            cdPos = spawnedGround.transform.GetChild(6);
            //spawnedGround.transform.position = cdPos.position;
        }

        else if(randomSide == 7)
        {
            cuPos = spawnedGround.transform.GetChild(7);
            //spawnedGround.transform.position = cuPos.position;
        }
        }
    }
}
