using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
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

    private void Start()
    {
        
    }
    void Update()
    {
        
        if (inTrigger)
        {
            if (close)
            {
                if (doorKey)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        open = true;
                        close = false;
                    }
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    close = true;
                    open = false;
                }
            }
        }

        if (inTrigger)
        {
            if (open)
            {
                var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 200);
                transform.rotation = newRot;
            }
            else
            {
                var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 0f, 0f), Time.deltaTime * 200);
            }
        }
        
        
    }
    private void OnGUI()
    {
        if (inTrigger)
        {
            if (open)
            {
                GUI.Box(new Rect(0, 0, 200, 25), "press E to close");
            }
            else
            {
                if (doorKey)
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Press E to open");
                }
                else
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Need a key");
                }
                
            }
        }
    }
}
