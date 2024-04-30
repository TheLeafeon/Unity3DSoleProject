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
        UnityEngine.Debug.Log("�������� ���� ���ݷ��� "+ attackPower_EquipWeapon + " �Դϴ�.");
    }


}
