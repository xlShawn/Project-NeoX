using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Shooter {

    [SerializeField] GameObject pointAt;

    void Update() {
        raycast();
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

        Debug.DrawRay(origin, direction*10f, Color.green);
    }

}
