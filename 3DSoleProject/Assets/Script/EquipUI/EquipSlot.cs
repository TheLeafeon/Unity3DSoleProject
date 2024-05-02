using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipSlot : MonoBehaviour
{
    public Image equipWeaponIcon;

    public ItemInformation itemInformation;

    public void UpdateSlotUI()
    {

        UnityEngine.Debug.Log("Update Slot UI");
        equipWeaponIcon.sprite = itemInformation.itemImage;

        equipWeaponIcon.gameObject.SetActive(true);
    }
    public void RemoveSlot()
    {
        equipWeaponIcon = null;
        equipWeaponIcon.gameObject.SetActive(false);
    }


}
