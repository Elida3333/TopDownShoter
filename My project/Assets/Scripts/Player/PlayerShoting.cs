using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoting : MonoBehaviour
{
    [SerializeField] float PlayerBulletSpeed = 10f;
    [SerializeField] GameObject PlayerBullet;
    [SerializeField] GameObject PlayerGun;
    void Start()
    {
        
    }

    void OnFire()
    {
      GameObject bullet = Instantiate(PlayerBullet, PlayerGun.transform.position, transform.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * PlayerBulletSpeed, ForceMode2D.Impulse);

    }
   
    void Update()
    {
        
    }
}
