using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullInstantiation : MonoBehaviour
{
    //attached to boss as these will become children elements due to need of start transform pos
    //Will be enabled and disabled through fsm state attack1 script (because I want a coroutine)
    [SerializeField] private GameObject skullProjectile;
    [SerializeField] private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        skullProjectile.SetActive(true);
        StartCoroutine("EnsureState");
        StartCoroutine("InstanSkull");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator InstanSkull()
    {
        //until gameobject anim state changes, do not return null and keep returning .3 sec
        bool isAttack = _animator.GetCurrentAnimatorStateInfo(0).IsName("Attack1");
        while (isAttack)
        {
            Instantiate(skullProjectile, transform.position + (Vector3.left) * 3, Quaternion.identity);
            yield return new WaitForSeconds(.75f);
            isAttack = _animator.GetCurrentAnimatorStateInfo(0).IsName("Attack1");
        }
        yield return null;
    }

    IEnumerator EnsureState()
    {
        yield return new WaitForSeconds(1f);
        yield return null;
    }
}
