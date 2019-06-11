using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomForSwitchA : MonoBehaviour
{
    public GameObject FutureEnvironment;
    public GameObject PastEnvironment;
    private bool SwitchBetweenFutureAndPast;
    public static bool intoRoom;

    void Update()
    {
        if(intoRoom == true)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                SwitchBetweenFutureAndPast = !SwitchBetweenFutureAndPast;
                if (SwitchBetweenFutureAndPast == true)
                {
                    FutureEnvironment.SetActive(false);
                    PastEnvironment.SetActive(true);
                    intoRoom = false;
                }

            }
        }

    }

    private void OnTriggerStay(Collider Col)
    {
        if (Col.attachedRigidbody)
        {
            intoRoom = true;
        }

    }
    private void OnTriggerExit(Collider Col)
    {
        intoRoom = false;
    }

    private void OnGUI()
    {
        if (intoRoom == true)
        {
            print("hello");

            GUI.Box(new Rect(0, 0, Screen.width / 9.6f, Screen.height / 43.2f), "Switch Area");
        }
    }
}
