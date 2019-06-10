using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour {
    //Hello, To use this script u need:
    //Assign this script to the door
    //Tag the door "Door"
    //Assign camera to a camera value in the script
    //Press "f" to open the door

    public float smooth = 1;
    public float angle = 90f;
    public Camera cam;
    Camera Cam;
    public float RayDistance = 1.7f;
    public float maxD = 1.7f;
    Ray ray;
   public bool open = false;
    Quaternion start;
    Quaternion end;
[Header("Auto = Finds Standard Asset Camera")]
    public bool AutoCamera = true;
    [Header("Auto Assigns a Tag <Door>")]
    public bool AutoTag = true;

    void Start () {
        if (AutoCamera)
        {
            cam = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        }
        if (AutoTag)
        {
            tag = "Door";
        }

        start = Quaternion.Euler(transform.rotation.eulerAngles.x, 0, transform.rotation.eulerAngles.z);
        end = Quaternion.Euler(transform.rotation.eulerAngles.x, -angle, transform.rotation.eulerAngles.z);
    }

    //Script by Total_Marginal 

    void Update () {
        if(open)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, end, Time.deltaTime * smooth);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, start, Time.deltaTime * smooth);
        }

        if (Input.GetKeyDown("f"))
        {
                ray = cam.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, RayDistance) && hit.transform.tag == "Door")
            {
                if (Vector3.Distance(hit.transform.position, this.transform.position) < maxD)
                {
                        open = !open;
                }
            }
        }
    }
}

