using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Slot : MonoBehaviour, IPointerClickHandler
{
    public GameObject item;
    public int ID;
    public string type;
    public string description;
    public bool empty;

    public Transform slotIconGO;
    public Sprite icon;

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        UseItem();
    }

    private void Start()
    {
        slotIconGO = transform.GetChild(0);
    }
    public void updateSlot()
    {
        slotIconGO.GetComponent<Image>().sprite = icon;  
    }
    public void UseItem()
    {
        item.GetComponent<Item>().ItemUsage();
    }

}
