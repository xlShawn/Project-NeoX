using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAudio : MonoBehaviour
{
    public AudioClip playerShooting;

    public AudioSource GunAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        GunAudioSource.clip = playerShooting;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GunAudioSource.clip = playerShooting;
            GunAudioSource.Play();
        }

    }
}