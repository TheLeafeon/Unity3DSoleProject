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
            UnityEngine.Debug.Log("for�� ���ư�����");
            ItemInformation nowItem = swords[i].GetComponent<ItemInformation>();
            if (nowItem.itemName == equip.equipItem.itemName)
            {
                swords[i].gameObject.SetActive(true);
            }
            else
            {
                UnityEngine.Debug.Log("nowItem�� �̸���: " + nowItem.itemName);
                UnityEngine.Debug.Log("equip.equipItem.itemName�� �̸���: " + equip.equipItem.itemName);
                swords[i].gameObject.SetActive(false);
            }    
        }
    }

}
