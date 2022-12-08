using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] GameObject targetplayer; 
    NavMeshAgent navMeshAgent;
    public CharacterController enemycontroller;
    [SerializeField] float gravity;
    Vector3 velocity;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        targetplayer = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(targetplayer.transform.position);
        enemygravity();
    }

    void enemygravity()
    {
        velocity.y += gravity * Time.deltaTime;
        enemycontroller.Move(velocity*Time.deltaTime);      
    }
}
