using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySingleton : MonoBehaviour
{
    private Animator _enemyAni;

    public static EnemySingleton Enemy;
    public int hpBoss = 100;

    void Start()
    {
        Enemy = this;
        _enemyAni = gameObject.GetComponent<Animator>();
    }

    
    void Update()
    {
        if (hpBoss == 75)
        {
            _enemyAni.SetBool("isPhase2", true);
        }

        if (hpBoss == 35)
        {
            _enemyAni.SetBool("isPhase3", true);
        }
    }
}
