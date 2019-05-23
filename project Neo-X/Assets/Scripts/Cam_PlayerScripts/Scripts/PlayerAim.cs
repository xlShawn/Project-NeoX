using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour{
   
   public void setRotation(float amount) {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x - amount, transform.eulerAngles.y, transform.eulerAngles.z);
    }

    public float getAngle() {
        return CheckAngle(transform.eulerAngles.x);
    }

    public float CheckAngle(float value) {
        float angle = value - 180;
        if (angle > 0) {
            return angle-180;
        }
        else {
            return angle + 180;
        }
    }


}
