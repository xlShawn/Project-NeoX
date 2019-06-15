using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressAudio : MonoBehaviour
{
    public AudioClip playerShootingAudio;

    public AudioSource playerAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        playerAudioSource.clip = playerShootingAudio;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            playerAudioSource.clip = playerShootingAudio;
            playerAudioSource.Play();
        }
    }
}