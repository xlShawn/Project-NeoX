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
        /*// Movement input
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 moveVelocity = moveInput.normalized * moveSpeed;
        controller.Move(moveVelocity);

        // Look input
        Ray ray = viewCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayDistance;

        if (groundPlane.Raycast(ray, out rayDistance))
        {
            Vector3 point = ray.GetPoint(rayDistance);
            //Debug.DrawLine(ray.origin,point,Color.red);
            controller.LookAt(point);
        }
        */

        PlayerMovement();
        // Weapon input
        if (weaponEquipment == true)
        {
            if (Input.GetMouseButton(0))
            {
                gunController.Shoot();
            }
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
