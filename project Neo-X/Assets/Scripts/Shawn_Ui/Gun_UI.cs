using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_UI : MonoBehaviour
{
    // as his Shooter;
    public Transform muzzle;
    public Projectile_UI projectile;
    public float msBetweenShots = 100;
    public float muzzleVelocity = 35;

    float nextShotTime;

    public void Shoot()
    {

        if (Time.time > nextShotTime)
        {
            nextShotTime = Time.time + msBetweenShots / 1000;
            Projectile_UI newProjectile = Instantiate(projectile, muzzle.position, muzzle.rotation) as Projectile_UI;
            newProjectile.SetSpeed(muzzleVelocity);
        }
    }
}
