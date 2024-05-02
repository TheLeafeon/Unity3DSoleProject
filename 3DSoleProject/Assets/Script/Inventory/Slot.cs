using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IPointerUpHandler
{
    public int  slotNum;
    public ItemInformation itemInformation;
    public Image itemIcon;

    public void UpdateSlotUI()
    {
        itemIcon.sprite = itemInformation.itemImage;

        itemIcon.gameObject.SetActive(true);
    }


    public void RemoveSlot()
    {
        itemInformation = null;
        itemIcon.gameObject.SetActive(false);
    }


    //Å¬¸¯
    public void OnPointerUp(PointerEventData eventData)
    {
        if(itemInformation != null)
        {
            bool isUse = itemInformation.Use();
            if (isUse)
            {
                Inventory.instance.RemoveItem(slotNum);
            }
        }


    }
}
