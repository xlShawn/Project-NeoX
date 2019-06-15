using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeaudio : MonoBehaviour
{
public AudioClip saw;    // Add your Audi Clip Here;
     // This Will Configure the  AudioSource Component; 
     // MAke Sure You added AudioSouce to death Zone;
	 public AudioSource CubeSource;
     void Start ()   
     {
        
         CubeSource.clip = saw;
     }        
 
     void OnCollisionEnter ()  //Plays Sound Whenever collision detected
     {
        	CubeSource.Play();
     }
}
