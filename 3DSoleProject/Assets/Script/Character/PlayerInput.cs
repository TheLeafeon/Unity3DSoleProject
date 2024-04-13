using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        bool isMove = moveInput.magnitude != 0;

        playerMovement.CharacterMove(moveInput);


        if(isMove)
        {
            playerMovement.SetWalkingAnimation(true);
        }
        else
        {
            playerMovement.SetWalkingAnimation(false);
        }
    }


}
