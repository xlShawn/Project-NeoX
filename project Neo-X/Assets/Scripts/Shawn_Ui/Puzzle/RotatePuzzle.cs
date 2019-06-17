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
        if (sculpture[0].rotation.y == 0f &&
            sculpture[1].rotation.y == 0f &&
            sculpture[2].rotation.y == 0f &&
            sculpture[3].rotation.y == 0f)
        {
            key.SetActive(true);
        }
    }
}
