using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkAudio : MonoBehaviour
{
    public AudioClip playerRun;

    public AudioSource WalkAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        WalkAudioSource.clip = playerRun;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            WalkAudioSource.clip = playerRun;

            WalkAudioSource.enabled = true;
            WalkAudioSource.loop = true;
        }
        else
        {
            WalkAudioSource.enabled = false;
            WalkAudioSource.loop = false;
        }

    }
}
