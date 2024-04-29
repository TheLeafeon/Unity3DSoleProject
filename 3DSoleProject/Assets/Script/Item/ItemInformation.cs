using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Equipment,
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
    
    //public ItemInformation GetItem()
    //{
    //    return this;
    //    return item;
    //}
    public void DestroyItem()
    {
        Destroy(gameObject);
    }


    public bool Use()
    {
        bool isUesd = false;

        switch (itemType)
        {
            case ItemType.Equipment:
                UnityEngine.Debug.Log(itemName + "은(는) 장비아이템 입니다.");
                break; 
            case ItemType.Consumables:
                UnityEngine.Debug.Log(itemName + "은(는) 소비아이템 입니다.");
                break;
            case ItemType.Etc:
                UnityEngine.Debug.Log(itemName + "은(는) 기타아이템 입니다.");
                break;
        }
        foreach (ItemEffect effect in effects)
        {
            isUesd = effect.ExcuteRole();
        }

        return isUesd;
    }
}
