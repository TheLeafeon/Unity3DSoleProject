using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator playerAnimator;

    private void Awake()
    {
        playerAnimator = GetComponent<Animator>();
    }

    public void Attack()
    {
        switch(Equip.equipinstance.equipWeaponInformation.weaponType)
        {
            case WeaponType.Sword:
                SwordAttack();
                break;
            case WeaponType.Gun:
                GunAttack();
                break;
            case WeaponType.Spear:
                SpearAttack();
                break;
        }
    }

    private void SwordAttack()
    {
        playerAnimator.SetTrigger("isSlash");
    }

    private void GunAttack()
    {
        playerAnimator.SetTrigger("isShoot");
    }

    private void SpearAttack()
    {

    }

    //public void SetAttackAnimation()
    //{
    //    playerAnimator.SetTrigger("isAttack");
    //}

    public void AttackEnd()
    {
        Player.PlayerInstance.isAttacking = false;
    }

}
