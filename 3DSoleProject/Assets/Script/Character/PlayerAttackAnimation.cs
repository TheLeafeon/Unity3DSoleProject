using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackAnimation : MonoBehaviour
{
    [SerializeField]
    private Transform characterBase;

    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = characterBase.GetComponent<PlayerInput>();
    }


    public void AttackEnd()
    {
        Player.PlayerInstance.isAttacking = false;
    }



}
