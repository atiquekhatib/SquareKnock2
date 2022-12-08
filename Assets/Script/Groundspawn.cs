using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Groundspawn : MonoBehaviour
{
[SerializeField] private GameObject ground;
[SerializeField] private GameObject Enemy;
public Transform cuPos;
public NavMeshSurface surface;
float gzpos;
[SerializeField] float gzspace;
//float gxpos;
//float gxrandom;

    void Start()
    {
        StartCoroutine(SpawnForwardGround());
    }

    IEnumerator SpawnForwardGround()
    {
        while(true)
        {
        yield return new WaitForSeconds(Random.Range(3,4));
        //gxrandom = Random.Range(-5,6);
        gzpos+=gzspace;
        //gxpos=gxrandom;
        //Debug.Log(gxpos);
        Instantiate(ground, new Vector3 (0,0,gzpos),cuPos.rotation);
        Instantiate(Enemy, new Vector3 (0,0,gzpos),cuPos.rotation);
        surface.BuildNavMesh();
        }
    }
}
