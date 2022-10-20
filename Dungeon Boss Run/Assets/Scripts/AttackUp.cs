using System.Collections;
using UnityEngine;

public class AttackUp : PickupItems
{
    [SerializeField] private AudioSource _audio;
    public override void Use()
    {
        if (!PlayerSingleton.player.isPowerUp)
        {
            PlayerSingleton.player.isPowerUp = true;
            _audio.Play();
            StartCoroutine("PowerAttack");
            PlayerSingleton.player.isPowerUp = false;
        }
    }

    IEnumerator PowerAttack()
    {
        yield return new WaitForSeconds(5f);
        yield return null;
    }
}
