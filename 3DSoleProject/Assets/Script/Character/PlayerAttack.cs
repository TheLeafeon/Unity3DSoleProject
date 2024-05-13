using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator playerAnimator;

    [SerializeField]
    public Transform WeaponPoint;

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

                playerAnimator.SetTrigger("isShoot");

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
        Shooting shooting = WeaponPoint.GetComponentInChildren<Shooting>();

        if (shooting != null)
        {
            shooting.Launch();
        }
        else
        {
            UnityEngine.Debug.Log("³Î ÂüÁ¶");
        }
        
    }

    private void SpearAttack()
    {

    }

    public void AttackEnd()
    {
        Player.PlayerInstance.isAttacking = false;
    }

}
