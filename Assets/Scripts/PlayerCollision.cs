using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] AudioSource coinAudio;

    private PlayerPointsCounter playerPointsCount;

    private float minX = -4;
    private float maxX = 5;

    private void Awake()
    {
        playerPointsCount = GetComponent<PlayerPointsCounter>();
    }

    private void Update()
    {
        PlayerBoundaring();
    }

    private void PlayerBoundaring()
    {
        if(transform.position.x <= minX)
        {
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }

        if(transform.position.x >= maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Coin"))
        {
            coinAudio.Play();
            playerPointsCount.points++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("WhiteCoin"))
        {
            coinAudio.Play();
            playerPointsCount.points *= 2;
            Destroy(collision.gameObject);
        }
    }
}