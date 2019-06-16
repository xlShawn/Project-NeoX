using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDissolve : MonoBehaviour {

    public string shaderDissolveKey = "Vector1_2E383190";
    public float startDissolve = 0f;
    public float reformStart = 1f;
    public float dissolveRate = 0.01f;
    public Material[] materials;

    private Renderer[] renderers;
    private AudioSource audioSource;

    private void Awake() {
        renderers = GetComponentsInChildren<Renderer>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.T)) {
            InvokeDissolve();
        }
        if (Input.GetKeyDown(KeyCode.R)) {
            InvokeReform();
        }
    }

    public void InvokeDissolve () {
        audioSource.Play();
        InvokeRepeating("Dissolve", 0, dissolveRate);
    }

    public void InvokeReform () {
        InvokeRepeating("Reform", 0, dissolveRate);
    }

    private void Dissolve () {
        CancelInvoke("Reform");
        reformStart = 0;
        for (int i = 0; i < materials.Length; i++) {
            materials[i].SetFloat(shaderDissolveKey, startDissolve += dissolveRate);
            audioSource.volume -= dissolveRate;
            if (materials[i].GetFloat(shaderDissolveKey) >= 1) {
                CancelInvoke("Dissolve");
            }
        }
    }

    private void Reform () {
        CancelInvoke("Dissolve");
        startDissolve = 1;
        for (int i = 0; i < materials.Length; i++) {
            materials[i].SetFloat(shaderDissolveKey, reformStart -= dissolveRate);
            if (materials[i].GetFloat(shaderDissolveKey) <= 0) {
                CancelInvoke("Reform");
            }
        }
    }

    private void PlayDissolveAudio () {
        audioSource.Play();
        audioSource.volume -= 0.1f;
    }

    private void OnApplicationQuit() {
        for (int i = 0; i < materials.Length; i++) {
            materials[i].SetFloat(shaderDissolveKey, 0);
        }
    }

}
