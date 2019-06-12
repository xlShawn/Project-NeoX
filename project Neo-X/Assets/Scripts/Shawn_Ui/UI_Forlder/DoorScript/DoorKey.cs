using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorKey : MonoBehaviour
{
    public bool inTrigger;

    private void Start()
    {
        inTrigger = false;
    }
    
    private void OnTriggerStay(Collider Col)
    {
        inTrigger = true;
    }

    private void OnTriggerExit(Collider Col)
    {
        inTrigger = false;

    }

    void Update()
    {

    }
    private void OnGUI()
    {
        if (inTrigger == true)
        {
            print("helloB");
            GUI.Box(new Rect(0, 0, Screen.width / 8f, Screen.height / 40f), "Press E to Pick Up");
        }
    }

}
