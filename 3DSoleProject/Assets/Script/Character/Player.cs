using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Singleton
    public static Player PlayerInstance;
    private void Awake()
    {
        if(PlayerInstance != null)
        {
           
            Destroy(gameObject);
            return;
        }
        PlayerInstance = this;
    }
    #endregion


    public GameObject equipWeapon;

    public int attackPower_EquipWeapon;


    private void Update()
    {
        UnityEngine.Debug.Log("장착중인 무기 공격력은 "+ attackPower_EquipWeapon + " 입니다.");
    }


}
