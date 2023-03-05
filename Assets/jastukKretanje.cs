using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jastukKretanje : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 150f;
    private Rigidbody2D rb;
    Vector3 direction;
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        direction = player.position - transform.position;
        direction.Normalize();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}
