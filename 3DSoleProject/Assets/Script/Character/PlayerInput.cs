using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    private PlayerAttack playerAttack;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
        playerAttack = GetComponent<PlayerAttack>();
    }

    private void Update()
    {
        if(!Player.PlayerInstance.isAttacking)
        {
            Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

            bool isMove = moveInput.magnitude != 0;

            playerMovement.CharacterMove(moveInput);

            if (isMove)
            {
                playerMovement.SetWalkingAnimation(true);
            }
            else
            {
                playerMovement.SetWalkingAnimation(false);
            }
        }

        //공격 키 입력
        if(Input.GetButtonDown("Fire1") && Equip.equipinstance.equipItem != null)
        {
            playerAttack.Attack();
            Player.PlayerInstance.isAttacking = true;
        }
    }


    
}
