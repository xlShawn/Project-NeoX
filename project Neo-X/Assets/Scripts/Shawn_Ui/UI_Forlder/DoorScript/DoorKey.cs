using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorKey : MonoBehaviour
{
    public bool inTrigger = false;
    private void OnTriggerEnter(Collider Col)
    {
        inTrigger = true;
    }

    private void OnTriggerExit(Collider Col)
    {
        inTrigger = false;

    }


    // Update is called once per frame
    void Update()
    {
        //if (inTrigger)
        //{
        //    if (Input.GetKeyDown(KeyCode.H))
        //    {
        //        DoorScript.doorKey = true;
        //        Destroy(this.gameObject);
        //    }
        //}
    }

    //private void OnGUI()
    //{
    //    if (inTrigger == true)
    //    {
    //        GUI.Box(new Rect(0, 60, 200, 25), "Press h tp take key");
    //    }
    //}

}
