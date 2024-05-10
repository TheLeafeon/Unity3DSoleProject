using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipWeaponSetActive : MonoBehaviour
{
    Equip equip;

    public Transform[] weapons;

    private void Start()
    {
        equip = Equip.equipinstance;
        equip.onChangeEquip += ActiveWeapon;
    }

    void ActiveWeapon()
    {
        UnityEngine.Debug.Log("장착 무기의 종류: " + equip.equipWeaponInformation.weaponType);


        for (int i = 0; i < weapons.Length; i++)
        {
            ItemInformation nowItem = weapons[i].GetComponent<ItemInformation>();
            if (nowItem.itemName == equip.equipItem.itemName)
            {
                weapons[i].gameObject.SetActive(true);
            }
            else
            {
                weapons[i].gameObject.SetActive(false);
            }
        }
    }

}
