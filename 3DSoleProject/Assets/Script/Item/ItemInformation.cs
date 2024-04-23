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

    
    //public ItemInformation GetItem()
    //{
    //    return this;
    //    return item;
    //}
    public void DestroyItem()
    {
        Destroy(gameObject);
    }
}
