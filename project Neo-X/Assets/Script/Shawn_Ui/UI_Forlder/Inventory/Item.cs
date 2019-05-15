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
    public bool equipped;

    public void Update()
    {
        if (equipped)
        {
            //perform weapon acts here

        }
    }

    public void ItemUsage()
    {

        //weapon
        if(type == "Weapon")
        {
            equipped = true;
        }

        //health

        //time

    }
}
