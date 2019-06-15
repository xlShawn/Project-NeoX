using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioScript : MonoBehaviour
{
public AudioClip shootingClip;
public AudioClip clip;
public AudioClip walk;
public AudioSource soundSource;

    // Start is called before the first frame update
    void Start()
    {
        soundSource.clip = walk;
    }

    // Update is called once per frame
    void Update()
    {
		
        if(Input.GetKeyDown(KeyCode.Space))
		{
			soundSource.clip = shootingClip;
			soundSource.Play();
			soundSource.Stop(); 
		}
		        if(Input.GetKeyDown(KeyCode.A))
		{
			soundSource.clip = clip;
			soundSource.Play();
			soundSource.Stop();
		}
    }
}
