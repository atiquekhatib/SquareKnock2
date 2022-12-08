using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHit : MonoBehaviour
{
public Vector3 currentpos;
NavMeshAgent navMeshAgent;

 void Start() 
{
  navMeshAgent = GetComponent<NavMeshAgent>();
}

void OnCollisionEnter(Collision other) 
{
    if(other.gameObject.tag == "Bullet")
        {
            Debug.Log("HIt");
            transform.Translate(Vector3.back *100 * Time.deltaTime);

            currentpos = gameObject.transform.position;
           // Debug.Log(currentpos);  
        }
  
}

}
