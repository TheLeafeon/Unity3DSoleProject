using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Weapon,
    Consumables,
    Etc
}

[System.Serializable]
public class ItemInformation : MonoBehaviour
{
    public ItemType itemType;
    public string itemName;
    public Sprite itemImage;
    public List<ItemEffect> effects;
    



    //아이템 삭제
    public void DestroyItem()
    {
        Destroy(gameObject);
    }

    //아이템 사용
    public bool Use()
    {
        bool isUesd = false;

        switch (itemType)
        {
            case ItemType.Weapon:
                UnityEngine.Debug.Log(itemName + "은(는) 무기아이템 입니다.");

                //isUesd = Equip.equipinstance.EquipItem(this);
                isUesd = Equip.equipinstance.EquipItem(this.gameObject.GetComponent<ItemInformation>());

                break; 
            case ItemType.Consumables:
                UnityEngine.Debug.Log(itemName + "은(는) 소비아이템 입니다.");

                foreach (ItemEffect effect in effects)
                {
                    isUesd = effect.ExcuteRole();
                }

                break;
            case ItemType.Etc:
                UnityEngine.Debug.Log(itemName + "은(는) 기타아이템 입니다.");
                break;
        }


        return isUesd;
    }
}
