using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    public GameObject startcanvas;
    void Awake() 
    {
        Time.timeScale = 0;    
    }

    public void startbutton()
    {
        startcanvas.SetActive(false);
        Time.timeScale = 1;
    }

}
