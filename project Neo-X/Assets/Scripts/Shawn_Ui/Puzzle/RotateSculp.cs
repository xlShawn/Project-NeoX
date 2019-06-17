using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSculp : MonoBehaviour
{
    public bool rota;
    private void Update()
    {
        if (rota == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                transform.Rotate(0f, 0f, 90f);
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        print("AAAAAA");
        if (other.attachedRigidbody)
        {
            rota = true;
        }
        

    }

    void OnTriggerExit(Collider other)
    {
        rota = false;
        Debug.Log("leaving");
    }
}
