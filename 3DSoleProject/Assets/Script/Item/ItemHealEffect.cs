using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ItemEffect/Consumable/Health")]
public class ItemHealEffect : ItemEffect
{
    public int healPoint = 0;
    public override bool ExcuteRole()
    {

        UnityEngine.Debug.Log("Player Healing: " + healPoint);

        return true;
    }
}
