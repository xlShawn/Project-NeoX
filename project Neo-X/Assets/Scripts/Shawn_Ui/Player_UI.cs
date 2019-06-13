using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(GunController))]
public class Player_UI : LivingEntity
{
    public float moveSpeed = 5;
    public static bool weaponEquipment = false;

   // Camera viewCamera;
   // PlayerController controller;
    GunController gunController;

    protected override void Start()
    {
        base.Start();
        //controller = GetComponent<PlayerController>();
        gunController = GetComponent<GunController>();
        //viewCamera = Camera.main;
        
    }

    void FixedUpdate()
    {
       

        PlayerMovement();
        // Weapon input
        if (weaponEquipment == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                gunController.Shoot();
            }
            return; 

        }
        
    }
    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, ver) * moveSpeed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);
    }

}
