using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    [SerializeField] Texture2D image;
    [SerializeField]public int size;
    [SerializeField] float maxAngle;
    [SerializeField] float minAngle;
    private bool inventoryEnable;

    public Vector2 crosshairPos;
    public Vector3 screenPosition;


    float lookHeight;
    void Update()
    {
        crosshairPos = new Vector2(screenPosition.x, screenPosition.y - lookHeight);

    }
    public void LookHeight(float value) {
        lookHeight += value;
        
        if (lookHeight > maxAngle || lookHeight < minAngle)
        {
            lookHeight -= value;
        }
        

    }

    void OnGUI() {
        screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        screenPosition.y = Screen.height - screenPosition.y;
        GUI.DrawTexture(new Rect(screenPosition.x, screenPosition.y - lookHeight, size, size), image);
    }
}
