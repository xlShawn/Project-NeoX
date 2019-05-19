using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeScript : MonoBehaviour
{
    Image timerBar;
    public float maxTime;
    float timeLeft;
    public bool hasStarted; 
    
    void Start()
    {

        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    void Update()
    {

        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }else
        {
            SceneManager.LoadScene(4);
            Time.timeScale = 0;
        }
              
    }

}
