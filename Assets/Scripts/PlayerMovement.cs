using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5;

    private Rigidbody2D rb;

    public float cooldown = 5;
    public bool usedBooster;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cooldown = 0;
    }

    private void Update()
    {
        PlayerMove();
        PlayerBooster();
    }

    private void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");

        rb.velocity = Vector2.right * x * speed;
    }

    private void PlayerBooster()
    {
        if(Input.GetKeyDown(KeyCode.Space) && cooldown <= 0)
        {
            usedBooster = true;
            cooldown = 5;
            speed *= 2;
        }

        if(speed > 5)
        {
            speed -= 0.8f * Time.deltaTime;
        }

        if (cooldown > 0 && speed <= 5)
        {
            speed = 5;
            cooldown -= Time.deltaTime;
        }

        if(cooldown <= 0 && usedBooster)
        {
            usedBooster = false;
        }
    }
}
