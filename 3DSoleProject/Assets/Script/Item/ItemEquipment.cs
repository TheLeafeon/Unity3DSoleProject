using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ItemEffect/Equipment/Weapon")]
public class ItemEquipment :  ItemEffect
{

    public int attackPower_Weapon;

    // 다른 오브젝트에 대한 참조
    public GameObject targetObject;

    // targetObject에 연결된 ItemInformation 컴포넌트
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
