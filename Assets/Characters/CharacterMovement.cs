using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    public float xSpeed = 1f, ySpeed = 0.75f;
    private Vector3 moveDelta;
    private RaycastHit2D movementHit;
    private BoxCollider2D myCollider;
    private bool _hasPlayerTarget;
    public bool HasPlayerTarget{
        get {return _hasPlayerTarget; }
        set {_hasPlayerTarget = value; }
    }
    protected virtual void Awake()
    {
        myCollider = GetComponent<BoxCollider2D>();
    }
    protected virtual void HandleMovement(float x, float y)
    {
        moveDelta = new Vector3(x * xSpeed, y * ySpeed, 0f);
        movementHit = Physics2D.BoxCast(transform.position, myCollider.size, 0f,
            new Vector2(0f, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime),
            LayerMask.GetMask("Blocking"));
        //if(movementHit.collider == null)
            transform.Translate(0f, moveDelta.y * Time.deltaTime, 0f);

        movementHit = Physics2D.BoxCast(transform.position, myCollider.size, 0f,
            new Vector2(moveDelta.x, 0f), Mathf.Abs(moveDelta.x * Time.deltaTime),
            LayerMask.GetMask("Blocking"));
        //if(movementHit.collider == null)
            transform.Translate(moveDelta.x * Time.deltaTime, 0f, 0f);
    }
    public Vector3 GetMoveDelta()
    {
        return moveDelta;
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
