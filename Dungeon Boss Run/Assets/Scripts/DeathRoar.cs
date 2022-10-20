using UnityEngine;

public class DeathRoar : MonoBehaviour
{
    [SerializeField] private AudioSource _deathRoar;
    [SerializeField] private Animator _bossAni;

    // Update is called once per frame
    void Update()
    {
        if (_bossAni.GetBool("victoryPlayer"))
        {
            _deathRoar.Play();
        }
    }
}
