using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Shooter {

    [SerializeField] GameObject pointAt;
    Crosshair ch; 

    void Update() {
        raycast();




        Ray ray = Camera.main.ScreenPointToRay(new Vector2(ch.crosshairPos.x+(ch.size/2), Mathf.Lerp(Screen.height, 0, ch.crosshairPos.y/Screen.height)-(ch.size/2)));
            RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction*30f, Color.green);
        
            if (Physics.Raycast(ray, out hit)) {
                print("Mouse hitting: " + hit.transform.name);
            }

        //print(Input.mousePosition);
        //print(ch.crosshairPos);


        //print("POS" + ch.crosshairPos);

        //Debug.DrawRay(Input.mousePosition);

    }



    public override void Fire() {
        base.Fire();
        if (canFire) {
            //Fire
        }
    }

    public void raycast() {
        Vector3 origin = transform.position;
        Vector3 direction = pointAt.transform.position-origin;
       //direction.y -= 2;

        //print(origin);

        //Debug.DrawRay(origin, direction*10f, Color.green);
    }

   void Start() {
        ch = FindObjectOfType<Crosshair>();
    }

}
