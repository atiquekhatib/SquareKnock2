using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] float survivalTime = 0f;
    [SerializeField] float bestTime = 0f;
    [SerializeField] Text countdowntext;
    [SerializeField] Text besttimetext;
    
    DeathHandler death;
    
    void Start()
    {
        death = GetComponent<DeathHandler>();
        survivalTime = 0;
    }

    void Update()
    {
     survivalTime +=1 * Time.deltaTime;
     countdowntext.text = survivalTime.ToString("Survival Time :-"+"0");
    }

    void deathcheck()
    {
        if(death.isDead == true)
        {
            Debug.Log("dead!!!!!!!!!!!!!!!!!");
            if(survivalTime > bestTime)
            {
                bestTime = survivalTime;
            besttimetext.text = bestTime.ToString("best Time :-"+"0");

            }
        }
    }
}
