using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private float horizontalInput;
    private SpriteRenderer playerSR;

    private void Start()
    {
        playerSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if(horizontalInput != 0)
        {
            FlipPlayer();
        }
    }

    private void FlipPlayer()
    {
        playerSR.flipX = horizontalInput < 0 ? true : false;
    }
}
