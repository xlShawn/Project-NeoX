using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPCController : MonoBehaviour
{

    public float RotationSpeed = 1f;
    public Transform Target, Player;
    float mouseX, mouseY;
    void Start()
    {
        Cursor.visible = false;//invisible cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void LateUpdate()
    {
        CamControl();
    }

    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;

        transform.LookAt(Target);

        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Player.rotation = Quaternion.Euler(0, mouseX, 0);
    }
}
