using System.Collections;
using UnityEngine;

public class FireInstantiation : MonoBehaviour
{
    [SerializeField] private Animator _bossAni;

    [SerializeField] private GameObject _Fire;
    // Start is called before the first frame update
    void OnEnable()
    {
        //call coroutine and setbool to go back to decide attack state when done with coroutine
        StartCoroutine("TimePhase");
        StartCoroutine("InstanFire");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //coroutine for instantiation of fire trail
    IEnumerator InstanFire()
    {
        while (!_bossAni.GetBool("doneWithFire"))
        {
            Instantiate(_Fire, transform.position + (Vector3.down * 2), Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
        yield return null;
    }
    
    //coroutine for simple phase time management
    IEnumerator TimePhase()
    {
        yield return new WaitForSeconds(25f);
        _bossAni.SetBool("doneWithFire", true);
        yield return null;
    }
}
