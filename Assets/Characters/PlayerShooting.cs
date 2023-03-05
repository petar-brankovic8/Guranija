using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;
    private Vector2 targetPos;
    private Vector2 direction;
    private Camera mainCam;
    private Vector2 bulletSpawnPosition;
    private Quaternion bulletRotation;
    private void Awake()
    {
        mainCam = Camera.main;
    }
    public void Shoot(Vector3 spawnPos)
    {
        Physics2D.IgnoreLayerCollision(4, 1);
        Physics2D.IgnoreLayerCollision(1, 0);

        targetPos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        
        bulletSpawnPosition = new Vector2(spawnPos.x, spawnPos.y);

        direction = (targetPos - bulletSpawnPosition).normalized;

        bulletRotation = Quaternion.Euler(0, 0,
            Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg);

        GameObject newBullet = Instantiate(bullet, spawnPos, bulletRotation);

        newBullet.GetComponent<Bullet>().MoveInDirection(direction);
    }
}
