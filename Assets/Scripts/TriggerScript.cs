using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle") || collision.gameObject.CompareTag("Coin") || collision.gameObject.CompareTag("WhiteCoin"))
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.CompareTag("Player"))
        {
            gameManager.isGameOver = true;
            Destroy(collision.gameObject);
        }
    }
}
