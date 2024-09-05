using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2f;

    private Rigidbody2D objectRb;

    private void Awake()
    {
        objectRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        objectRb.velocity = Vector2.down * speed;
    }
}
