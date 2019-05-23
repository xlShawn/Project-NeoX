using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSwitch : MonoBehaviour
{
    public GameObject FutureEnvironment;
    public GameObject PastEnvironment;
    private bool SwitchBetweenFutureAndPast;
    public int switchTime = 3;
    private bool switchStop;

    void Update()
    {
        if(switchTime == 0)
        {
            switchStop = true;
        }
        if(switchStop == false)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                SwitchBetweenFutureAndPast = !SwitchBetweenFutureAndPast;
                switchTime -= 1;
            }
            if (SwitchBetweenFutureAndPast == true)
            {
                FutureEnvironment.SetActive(true);
                PastEnvironment.SetActive(false);
            }
            else
            {
                FutureEnvironment.SetActive(false);
                PastEnvironment.SetActive(true);
            }
        }


    }
}
