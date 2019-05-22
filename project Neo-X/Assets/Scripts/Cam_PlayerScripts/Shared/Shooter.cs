using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public float rateOfFire;
    [SerializeField] Projectile projectile;

    [HideInInspector]
    public Transform muzzle;

    float nextFireAllowed;
    public bool canFire;

    void Awake() {
        muzzle = transform.Find("Muzzle");
    }

    public virtual void Fire() {
       

        canFire = false;
        if(Time.time < nextFireAllowed) {
            return;
        }

        nextFireAllowed = Time.time + rateOfFire;

        //Instantiate the projectile
        Instantiate(projectile, muzzle.position, muzzle.rotation);

        print("FIRE!"+ Time.time);

        canFire = true;
    }

}
