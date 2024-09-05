using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairAnimator : MonoBehaviour
{
    private float horizontalInput;
    private SpriteRenderer hairSR;

    private void Start()
    {
        hairSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput != 0)
        {
            FlipHair();
        }
    }

    private void FlipHair()
    {
        hairSR.flipX = horizontalInput < 0 ? true : false;
    }
}
