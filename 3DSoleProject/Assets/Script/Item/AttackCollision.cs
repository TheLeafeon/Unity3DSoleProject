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
        }
    }
}