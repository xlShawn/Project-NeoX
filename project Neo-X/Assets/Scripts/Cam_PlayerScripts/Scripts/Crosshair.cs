using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    [SerializeField] Texture2D image;
    [SerializeField] int size;
    [SerializeField] float maxAngle;
    [SerializeField] float minAngle;
    private bool inventoryEnable;

    float lookHeight;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryEnable = !inventoryEnable;
        }

    }
    public void LookHeight(float value) {
        lookHeight += value;
        if (!inventoryEnable)
        {
            if (lookHeight > maxAngle || lookHeight < minAngle)
            {
                lookHeight -= value;
            }
        }

    }

    void OnGUI() {
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        screenPosition.y = Screen.height - screenPosition.y;
        GUI.DrawTexture(new Rect(screenPosition.x, screenPosition.y - lookHeight, size, size), image);
    }
}
