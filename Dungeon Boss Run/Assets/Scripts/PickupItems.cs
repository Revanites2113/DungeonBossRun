using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public abstract class PickupItems : MonoBehaviour
{
    //use start to appear and set coroutine for it to disappear in set time
    //need to instantiate randomly somewhere else maybe a script attached to the tilemap?
    public void OnEnable()
    {
        StartCoroutine("Gone");
        Appear();
    }

    //update to check if pickup occurs (use entryTrigger)
    //Gives random position within arena to appear applied to all pickups
    public void Appear()
    {
        float xMin = -16f;
        float xMax = 16.4f;
        float xPos = Random.Range(xMin, xMax);
        float yMin = 5.5f;
        float yMax = 6.1f;
        float yPos = Random.Range(yMin, yMax);
        transform.position = new Vector2(xPos, yPos);
    }

    //this needs to be overriden to apply different effects depending on child element
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            //from here it is all based on class
            Use();
        }
    }

    public virtual void Use()
    {
        
    }

    IEnumerator Gone()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
        yield return null;
    }
}
