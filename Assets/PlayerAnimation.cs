using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    // Start is called before the first frame update


    public float speed = 0.5f;
    public Rigidbody2D rd;
    public Vector2 movement;
    public Animator animation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");


    }

    void FixedUpdate()
    {
        rd.MovePosition(rd.position + movement * speed * Time.fixedDeltaTime);
    }
}
