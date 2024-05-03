using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ItemEffect/Equipment/Weapon")]
public class ItemEquipment :  ItemEffect
{

    public int attackPower_Weapon;

    // �ٸ� ������Ʈ�� ���� ����
    public GameObject targetObject;

    // targetObject�� ����� ItemInformation ������Ʈ
    private ItemInformation itemInformation;

    private WeaponInformation weaponInformation;


    public void Start()
    {
        itemInformation = targetObject.GetComponent<ItemInformation>();
        weaponInformation = targetObject.GetComponent<WeaponInformation>();
    }
    public override bool ExcuteRole()
    {
        //, weaponInformation
        //Equip.equipinstance.EquipItem(itemInformation);

        return true;
    }
}
