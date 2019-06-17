using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSlide : MonoBehaviour
{

    public GameObject trigger;
    public GameObject door;
    Animator DoorMove;

    // Start is called before the first frame update
    void Start()
    {
        DoorMove = door.GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            MovePaint(true);
        }
    }
    private void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            MovePaint(false);
        }
    }
    void MovePaint(bool state)
    {
        DoorMove.SetBool("slide", state);
    }
}
