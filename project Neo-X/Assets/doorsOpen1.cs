using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorsOpen1 : MonoBehaviour
{
    public static bool doorKey;
    public bool open;
    public bool close;

    public bool inTrigger;

    private void OnTriggerEnter(Collider Col)
    {
        inTrigger = true;
    }
    private void OnTriggerExit(Collider Col)
    {
        inTrigger = false;
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E)) 
        {
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 200);
            transform.rotation = newRot;
        }
        else
        {
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 0f, 0f), Time.deltaTime * 200);
        }


    }
    private void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(0, 0, Screen.width / 8f, Screen.height / 40f), "Press E to open");
        }
    }
}
