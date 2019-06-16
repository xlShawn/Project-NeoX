using System.Collections;
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
    public AudioClip pastAudio;
    public AudioSource BackgroundAudioSource;
    public Animator animator;

    void Start()
    {
        

    }
    void Update()
    {
        if (intoRoom == true)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                Invoke("IntoTheRoom", 1f);
                animator.SetTrigger("FadeIn");
                animator.Play("NeonFieldAnim");
            }
        }

    }

    void IntoTheRoom()
    {
        
        SwitchBetweenFutureAndPast = !SwitchBetweenFutureAndPast;
        if (SwitchBetweenFutureAndPast == true)
        {
            StartCoroutine(Waiting());
            FutureEnvironment.SetActive(false);
            PastEnvironment.SetActive(true);
            intoRoom = false;

            playerAudioSource.clip = roomSwitchAudio;
            playerAudioSource.Play();

            BackgroundAudioSource.enabled = true;
            BackgroundAudioSource.clip = pastAudio;
            BackgroundAudioSource.Play();

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

            GUI.Box(new Rect(0, 0, Screen.width / 8f, Screen.height / 40f), "Switch Area");
        }
    }
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(2f);
        print("wait");
    }
}
