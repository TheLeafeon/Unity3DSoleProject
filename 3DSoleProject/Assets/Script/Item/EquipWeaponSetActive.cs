using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipWeaponSetActive : MonoBehaviour
{
    Equip equip;
    public Transform[] swords;

    private void Start()
    {
        equip = Equip.equipinstance;
        equip.onChangeEquip += ActiveWeapon;
    }

    private void Update()
    {

    }

    void ActiveWeapon()
    {
        for(int i = 0;i<swords.Length; i++)
        {
            UnityEngine.Debug.Log("for문 돌아가는중");
            ItemInformation nowItem = swords[i].GetComponent<ItemInformation>();
            if (nowItem.itemName == equip.equipItem.itemName)
            {
                swords[i].gameObject.SetActive(true);
            }
            else
            {
                UnityEngine.Debug.Log("nowItem의 이름은: " + nowItem.itemName);
                UnityEngine.Debug.Log("equip.equipItem.itemName의 이름은: " + equip.equipItem.itemName);
                swords[i].gameObject.SetActive(false);
            }    
        }
    }

}
