using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grounddestroy : MonoBehaviour
{
    [SerializeField] float destroyTime;
    [SerializeField] float currentTime;
    [SerializeField] Text countdowntext;

    
   void Start() 
    {
        currentTime = destroyTime;    
    }

    void Update()
    {
        currentTime -=1 * Time.deltaTime;
        countdowntext.text = currentTime.ToString("0");
        Invoke("destroy",destroyTime);
    }

    void destroy()
    {
     Destroy(gameObject);
    }
}
