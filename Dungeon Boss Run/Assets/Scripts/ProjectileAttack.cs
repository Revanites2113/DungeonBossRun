using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileAttack : MonoBehaviour
{
    private Animator playerAni;
    private bool _isHit = false;

    private Vector2 _velocity = new Vector2(-1, 0);
    private float _speed = 3f;
    private Vector2 _velocityHit = new Vector2(2, 0);
    
    // Start is called before the first frame update
    void Start()
    {
        playerAni = PlayerSingleton.player.GetComponent<Animator>();
    }

    // Update is called once per frame
    //check if enemy, wall or player. If wall, destroy object. If player, do check below. If enemy, take away HP from boss
    //check player animation state when colliding with player
    //coroutine for time check
    void Update()
    {
        //check if player has hit to continue going left or based on player force
        if (_isHit == false)
        {
            transform.Translate(_velocity * _speed * Time.deltaTime );
        }
        else
        {
            transform.Translate(_velocityHit * _speed * Time.deltaTime);
        }
    }
    
    //collision function
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Wall")
        {
            Destroy(gameObject);
        }

        if (col.collider.tag == "Player")
        {
            //check anim state
            if (!playerAni.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
                //do player damage and then destroy instatiation
                PlayerSingleton.player.health -= 1;
                Destroy(gameObject);
            }
            else
            {
                _isHit = true;
            }
        }

        if (col.collider.tag == "Boss")
        {
            //do enemy damage then destroy instatiation
            //also branch based on if player is powered up
            if (PlayerSingleton.player.isPowerUp)
            {
                EnemySingleton.Enemy.hpBoss -= 3;
            }
            else
            {
                EnemySingleton.Enemy.hpBoss -= 1;
            }
            Destroy(gameObject);
        }
    }
}
