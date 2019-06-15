using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomForSwitchB : MonoBehaviour
{
    public GameObject FutureEnvironment;
    public GameObject PastEnvironment;
    private bool SwitchBetweenFutureAndPast;
    public static bool intoRoomB;
	
	public AudioClip roomSwitchAudio;
    public AudioSource playerAudioSource;

    public Animator animator;
   
    void Update()
    {
        
        if (intoRoomB == true)
        {

            if (Input.GetKeyDown(KeyCode.Tab))
            {
                Invoke("IntoTheRoom", 1f);
                animator.SetTrigger("FadeOut");
                
            }

        }
    }
    void IntoTheRoom()
    {

        SwitchBetweenFutureAndPast = !SwitchBetweenFutureAndPast;

        if (SwitchBetweenFutureAndPast == true)
        {
            StartCoroutine(WaitForSec());
            FutureEnvironment.SetActive(true);
            PastEnvironment.SetActive(false);

            playerAudioSource.clip = roomSwitchAudio;
            playerAudioSource.Play();
        }
        intoRoomB = false;
    }

    private void OnTriggerStay(Collider Col)
    {

        if (Col.attachedRigidbody)
        {
            intoRoomB = true;
        }
    }
    private void OnTriggerExit(Collider Col)
    {
        intoRoomB = false;
    }

    private void OnGUI()
    {
        if (intoRoomB == true)
        {

            GUI.Box(new Rect(0, 0, Screen.width / 8f, Screen.height / 40f), "Switch Area");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(2f);
        print("yes");
    }
}
