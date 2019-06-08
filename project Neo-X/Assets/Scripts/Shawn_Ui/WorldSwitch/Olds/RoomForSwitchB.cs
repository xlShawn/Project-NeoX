using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomForSwitchB : MonoBehaviour
{
    public GameObject FutureEnvironment;
    public GameObject PastEnvironment;
    private bool SwitchBetweenFutureAndPast;
    public static bool intoRoomB;

    void Update()
    {
        if (intoRoomB == true)
        {

            if (Input.GetKeyDown(KeyCode.Tab))
            {
                SwitchBetweenFutureAndPast = !SwitchBetweenFutureAndPast;
                if (SwitchBetweenFutureAndPast == true)
                {
                    FutureEnvironment.SetActive(true);
                    PastEnvironment.SetActive(false);

                }
                intoRoomB = false;
            }

        }
    }

    private void OnTriggerStay(Collider Col)
    {

        if (Col.attachedRigidbody)
        {
            intoRoomB = true;

        }
    }
    private void OnTriggerExit(Collider Col)
    {
        intoRoomB = false;
    }

    private void OnGUI()
    {
        if (intoRoomB == true)
        {
            print("helloB");
            GUI.Box(new Rect(0, 0, 200, 25), "Switch Area");
        }
    }
}
