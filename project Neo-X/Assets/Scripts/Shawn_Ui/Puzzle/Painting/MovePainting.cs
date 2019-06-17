using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePainting : MonoBehaviour
{
    [SerializeField]
    private Transform[] painting;

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
        if (painting[0].position.y == 4f &&
            painting[1].position.y == 4f &&
            painting[2].position.y == 4f &&
            painting[3].position.y == 4f)
        {
            key.SetActive(true);
        }
    }
}
