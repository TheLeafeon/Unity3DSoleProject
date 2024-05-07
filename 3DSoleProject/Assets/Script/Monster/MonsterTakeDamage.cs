using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTakeDamage : MonoBehaviour
{
    private bool isInvinsible;

    private void Start()
    {
        isInvinsible = false;
    }

    public void TakeDamage(int damage)
    {
        MonsterInformation monsterInformation = GetComponent<MonsterInformation>();
        MonsterAnimationController monsterAni = GetComponent<MonsterAnimationController>();

        if (!isInvinsible)
        {
            monsterInformation.monsterHp -= damage;
            if (monsterInformation.monsterHp > 0) //안죽었을때 
            {
                monsterAni.SetHitAnimation();
                UnityEngine.Debug.Log("공격 성공. 남은 체력: " + monsterInformation.monsterHp);
            }
            else //죽었을때
            {
                monsterAni.SetDeathAnimation();
                UnityEngine.Debug.Log("몬스터 처치");
            }



            isInvinsible = true;
        }
    }
    public void InvinsibleEnd()
    {
        isInvinsible = false;
        UnityEngine.Debug.Log("무적 끝");
    }

    public void MonsterDestroy()
    {
        Destroy(gameObject);
    }
}
