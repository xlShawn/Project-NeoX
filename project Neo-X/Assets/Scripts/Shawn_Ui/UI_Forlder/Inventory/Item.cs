using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int ID;
    public string type;
    public string description;
    public Sprite icon;
    public bool pickedUp;

    [HideInInspector]
    public bool equipped;

    [HideInInspector]
    public GameObject weapon;

    [HideInInspector]
    public GameObject weaponManager;

    [HideInInspector]
    public GameObject playerUI;

    public bool playersWeapon;


    public void Start()
    {
        weaponManager = GameObject.FindWithTag("WeaponManager");
        if (!playersWeapon)
        {
            int allWeapons = weaponManager.transform.childCount;
            for (int i = 0; i < allWeapons; i++)
            {
                if(weaponManager.transform.GetChild(i).gameObject.GetComponent<Item>().ID == ID)
                {
                    weapon = weaponManager.transform.GetChild(i).gameObject;
                }
            }
            
        }
    }

    public void Update()
    {
        if (equipped)
        {
            //perform weapon acts here

        }
    }

    public void ItemUsage()//If there is new Items that need to use, this function should add New type  
    {

        //key
        //if (type == "Key")
        //{
        //    DoorScript.doorKey = true;
        //    equipped = true;
        //}


        //weapon
        if (type == "Weapon")
        {
            Player_UI.weaponEquipment = true;
            weapon.SetActive(true);
            equipped = true;
        }

        //health

        //time

    }
}
