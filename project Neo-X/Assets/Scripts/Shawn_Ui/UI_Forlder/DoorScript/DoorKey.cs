﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorKey : MonoBehaviour
{
    public bool inTrigger;

    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;

    }


    // Update is called once per frame
    void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                DoorScript.doorKey = true;
                Destroy(this.gameObject);
            }
        }
    }

}
