using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ItemEffect/Equipment/Weapon")]
public class ItemEquipment :  ItemEffect
{


    [SerializeField]
    private GameObject weaponAttachPoint;

    bool playerEquip = false;

    public int attackPower_Weapon;

    private void Start()
    {
        // Inventory.instance.RemoveItem(slotNum);
        
    }

    public override bool ExcuteRole()
    {
        if (playerEquip == false)
        {
            UnityEngine.Debug.Log("장비 장착 완료!");

            Player.PlayerInstance.attackPower_EquipWeapon = attackPower_Weapon;
            playerEquip = true;
        }
        else
        {
            Player.PlayerInstance.attackPower_EquipWeapon = attackPower_Weapon;

            UnityEngine.Debug.Log("장비 교체 완료!");
        }

        return true;
    }
}
