using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speedMove = 1f;

    Rigidbody2D enemyRigidbody2D;

    void Start()
    {
        enemyRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        enemyRigidbody2D.velocity = new Vector2(speedMove, 0f);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        ToggleDirection();
    }

    void ToggleDirection()
    {
        speedMove = -speedMove;
        float signum = Mathf.Sign(enemyRigidbody2D.velocity.x);
        transform.localScale = new Vector2(-signum, 1f);
    }
}
