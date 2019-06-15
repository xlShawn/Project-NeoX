using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkAudio : MonoBehaviour
{
    public AudioClip playerRun;

    public AudioSource PlayerAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        PlayerAudioSource.clip = playerRun;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            PlayerAudioSource.clip = playerRun;
 
            PlayerAudioSource.enabled = true;
            PlayerAudioSource.loop = true;
        }
        else
        {
            PlayerAudioSource.enabled = false;
            PlayerAudioSource.loop = false;
        }

    }
}
