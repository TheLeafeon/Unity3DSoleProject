using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {

        if(collision.CompareTag("Monster") && Player.PlayerInstance.isAttacking )
        {
            UnityEngine.Debug.Log("공격 성공!");

            MonsterTakeDamage monsters = collision.GetComponent<MonsterTakeDamage>();

            if (monsters != null)
            {
                monsters.TakeDamage(Equip.equipinstance.equipWeaponInformation.weaponAttackPower);

            }
        }
    }
}