﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomForSwitchA : MonoBehaviour
{
    public GameObject FutureEnvironment;
    public GameObject PastEnvironment;
    private bool SwitchBetweenFutureAndPast;
    public static bool intoRoom;

    public AudioClip roomSwitchAudio;
    public AudioSource playerAudioSource;

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

                    playerAudioSource.clip = roomSwitchAudio;
                    playerAudioSource.Play();
                   
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

            GUI.Box(new Rect(0, 0, Screen.width / 8f, Screen.height / 40f), "Switch Area");
        }
    }
}
