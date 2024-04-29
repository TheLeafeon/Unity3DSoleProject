using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ItemEffect/Equipment/Weapon")]
public class ItemEquipment : ItemEffect
{
    //[SerializeField]
    //PlayerEquip playerEquip;

    bool playerEquip = false;


    public override bool ExcuteRole()
    {
        if (playerEquip == false)
        {
            UnityEngine.Debug.Log("��� ���� �Ϸ�!");
            playerEquip = true;
        }
        else
        {
            UnityEngine.Debug.Log("��� ��ü �Ϸ�!");
        }

        return true;
    }
}
