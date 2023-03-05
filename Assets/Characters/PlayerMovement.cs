using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : CharacterMovement
{
    private float moveX, moveY;

    public bool ziv = true;
    
    private Camera mainCam;

    private Vector2 mousePosition;
    private Vector2 direction;
    private Vector3 tempScale;
    public GameOverScreen gameOverScreen;
    protected override void Awake()
    {
        base.Awake();

        mainCam = Camera.main;
    }
    private void FixedUpdate()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
        HandleMovement(moveX, moveY);
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.CompareTag("Enemy"))
        {
            ziv = false;
            gameOverScreen.Setup(13);
            Destroy(gameObject);
        }
            
    }
}
