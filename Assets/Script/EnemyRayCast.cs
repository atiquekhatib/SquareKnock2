using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyRayCast : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    [SerializeField] float range;
    NavMeshAgent navMesh;
    CharacterController enemycontroller;

    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        enemycontroller = GetComponent<CharacterController>();
        enemycontroller.enabled = false;
    }

    void Update()
    {
        GroundCheck();
    }

    void GroundCheck()
    {
        RaycastHit checkground;

        if(Physics.Raycast(Enemy.transform.position, -Enemy.transform.up, out checkground, range))
        {
            Debug.Log("we hit" +checkground.transform.name);
        }

        else
        {   
            Debug.Log("not hit");
            navMesh.isStopped = true;
            //Enemy.AddComponent<Rigidbody>();
            enemycontroller.enabled = true;
            Invoke("EnemyDestroy",1f);
        }
    }

    void EnemyDestroy()
    {
        Destroy(gameObject);
    }
}
