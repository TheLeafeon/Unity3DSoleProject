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
            UnityEngine.Debug.Log("��� ���� �Ϸ�!");

            Player.PlayerInstance.attackPower_EquipWeapon = attackPower_Weapon;
            playerEquip = true;
        }
        else
        {
            Player.PlayerInstance.attackPower_EquipWeapon = attackPower_Weapon;

            UnityEngine.Debug.Log("��� ��ü �Ϸ�!");
        }

        return true;
    }
}
