using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] float range;
    public bool isDead;
    [SerializeField] GameObject startCanvas;


    void Update()
    {
        GroundCheck();
    }

    void GroundCheck()
    {
        RaycastHit checkground;

        if(Physics.Raycast(Player.transform.position, -Player.transform.up, out checkground, range))
        {
            Debug.Log("Alive" +checkground.transform.name);
        }

        else
        {   
            StartCoroutine(GameOver());
        }
    }

    IEnumerator GameOver()
    {
        isDead = true;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(0);
    }
}
