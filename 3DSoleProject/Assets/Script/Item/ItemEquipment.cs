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

    public void Start()
    {
        itemInformation = targetObject.GetComponent<ItemInformation>();
    }
    public override bool ExcuteRole()
    {
       
            Equip.equipinstance.EquipItem(itemInformation);
       
        //Equip.equipinstance.EquipItem(ItemInformation _item);

        return true;
    }
}
