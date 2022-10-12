using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySingleton : MonoBehaviour
{
    public static EnemySingleton Enemy;
    public int hpBoss = 9;

    private void Awake()
    {
        Enemy = this;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
