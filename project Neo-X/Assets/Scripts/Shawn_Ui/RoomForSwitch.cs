using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomForSwitch : MonoBehaviour
{
    public bool inRoom = false;
    void Update()
    {
        if (inRoom == true)
        {
            FPSwitch.intoRoom = true;
        }
    }


    private void OnTriggerEnter(Collider Col)
    {
        inRoom = true;
    }
    private void OnTriggerExit(Collider Col)
    {
        inRoom = false;
    }

    private void OnGUI()
    {
        if (inRoom == true)
        {
            GUI.Box(new Rect(0, 0, 200, 25), "Switch Area");
        }
    }
}
