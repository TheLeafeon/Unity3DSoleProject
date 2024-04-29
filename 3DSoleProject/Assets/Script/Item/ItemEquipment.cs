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
            UnityEngine.Debug.Log("장비 장착 완료!");
            playerEquip = true;
        }
        else
        {
            UnityEngine.Debug.Log("장비 교체 완료!");
        }

        return true;
    }
}
