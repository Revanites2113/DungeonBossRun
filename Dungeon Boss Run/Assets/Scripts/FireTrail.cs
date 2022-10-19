using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrail : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //start couroutine to die and check for collisions with player as single object
        //Again just let boss instantiate these while going towards player
        StartCoroutine("Fade");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Fade()
    {
        yield return new WaitForSeconds(8f);
        Destroy(gameObject);
        yield return null;
    }
    
    //collision handeler to do player damage
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            PlayerSingleton.player.health -= 1;
        }
    }
}
