using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipSlot : MonoBehaviour
{
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



}
