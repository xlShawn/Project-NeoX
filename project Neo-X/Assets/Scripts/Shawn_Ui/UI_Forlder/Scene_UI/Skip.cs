using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Skip : MonoBehaviour
{

    public void Start()
    {
        //if(Input.GetKeyDown(KeyCode.R))
        //{
        //    Application.LoadLevel("Dialogue");
        //}
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("Level");
        }
    }
}
