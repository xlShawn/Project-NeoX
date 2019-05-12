using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timeStart;
    public Text textBox;

    bool timerActive = false;
    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString("F2");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            timeStart += Time.deltaTime;
            textBox.text = timeStart.ToString("F2");
        }
    }
    public void timerButton()
    {
        timerActive = !timerActive;
    }
}
