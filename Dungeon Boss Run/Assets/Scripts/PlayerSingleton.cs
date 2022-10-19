using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSingleton : MonoBehaviour
{
    //general player info for world like HP and defense
    //also setting up player as a singleton
    public static PlayerSingleton player;

    public int health = 3;
    public bool isPowerUp;
    

    void Start()
    {
        player = this;
    }
    void Update()
    {
        if (health <= 0)
        {
            //game over here using animation, screen and such (one of the last things honestly)
        }
    }
}
