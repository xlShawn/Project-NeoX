using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePuzzle : MonoBehaviour
{
    [SerializeField]
    private Transform[] sculpture;

    [SerializeField]
    private GameObject key;

    public static bool youGetKey;

    void Start()
    {
        key.SetActive(false);
        youGetKey = false;
    }


    void Update()
    {
        print("0: "+ sculpture[0].rotation.z);
        //print("1: " + sculpture[1].rotation.z);
        //print("2: " + sculpture[2].rotation.z);
        //print("3: " + sculpture[3].rotation.z);


        if (sculpture[0].rotation.z < 5f && sculpture[0].rotation.z > -5f &&
            sculpture[1].rotation.z < 5f && sculpture[1].rotation.z > -5f &&
            sculpture[2].rotation.z < 5f && sculpture[2].rotation.z > -5f &&
            sculpture[3].rotation.z < 5f && sculpture[3].rotation.z > -5f)
        {
            key.SetActive(true);
        }
    }
}
