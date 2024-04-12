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
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerMovement.CharacterMove(horizontalInput, verticalInput);

        if(horizontalInput != 0.0f || verticalInput != 0.0f)
        {
            playerMovement.SetWalkingAnimation(true);
        }
        else
        {
            playerMovement.SetWalkingAnimation(false);
        }
    }


}
