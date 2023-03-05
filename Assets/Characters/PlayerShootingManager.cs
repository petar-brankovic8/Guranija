using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingManager : MonoBehaviour
{
    [SerializeField]
    private float shootingTimerLimit = 0.2f;
    private float shootingTimer;

    [SerializeField]
    private Transform bulletSpawnPos;
    private PlayerShooting playerShooting;
    private void Awake()
    {
        playerShooting = GetComponent<PlayerShooting>();
    }
    private void Update()
    {
        HandleShooting();
    }
    void HandleShooting()
    { 
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > shootingTimer)
            {
                shootingTimer = Time.time + shootingTimerLimit;

                CreateBullet();
            }
        }
    }
    void CreateBullet()
    {
        playerShooting.Shoot(bulletSpawnPos.position);
    }
}
