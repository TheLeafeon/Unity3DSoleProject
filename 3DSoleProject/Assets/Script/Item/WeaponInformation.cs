using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum WeaponType
{
    Sword,
    Spear,
    Gun
}

public class WeaponInformation : MonoBehaviour
{
    public WeaponType weaponType;
    public int weaponAttackPower;
    
}
