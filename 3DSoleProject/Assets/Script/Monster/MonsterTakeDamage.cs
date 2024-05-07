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
            if (monsterInformation.monsterHp > 0) //���׾����� 
            {
                monsterAni.SetHitAnimation();
                UnityEngine.Debug.Log("���� ����. ���� ü��: " + monsterInformation.monsterHp);
            }
            else //�׾�����
            {
                monsterAni.SetDeathAnimation();
                UnityEngine.Debug.Log("���� óġ");
            }



            isInvinsible = true;
        }
    }
    public void InvinsibleEnd()
    {
        isInvinsible = false;
        UnityEngine.Debug.Log("���� ��");
    }

    public void MonsterDestroy()
    {
        Destroy(gameObject);
    }
}
