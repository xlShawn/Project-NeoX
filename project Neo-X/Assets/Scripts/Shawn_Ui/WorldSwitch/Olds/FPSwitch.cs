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
    public static bool intoRoom = false;

    void Update()
    {

        if (switchTime == 0)
        {
            switchStop = true;
        }
        if (switchStop == false)
        {
            if (intoRoom == true)
            {

                if (Input.GetKeyDown(KeyCode.Tab))
                {
                    SwitchBetweenFutureAndPast = !SwitchBetweenFutureAndPast;
                    if (SwitchBetweenFutureAndPast == true)
                    {
                        FutureEnvironment.SetActive(false);
                        PastEnvironment.SetActive(true);
                    }
                    else
                    {

                        FutureEnvironment.SetActive(true);
                        PastEnvironment.SetActive(false);
                    }
                    return;
                }
            }



        }
    }
}