using System.Collections;
using UnityEngine;

public class HealthPickup : PickupItems
{
    [SerializeField] private AudioSource _sound;
    //override use to alter playersingleton health aspect by adding +1 simply
    public override void Use()
    {
        if (PlayerSingleton.player.health < 3)
        {
            PlayerSingleton.player.health += 1;
            _sound.Play();
            //wait like half a second then destroy
            StartCoroutine("WaitToDestroy");
            Destroy(gameObject);
        }
    }

    IEnumerator WaitToDestroy()
    {
        yield return new WaitForSeconds(.75f);
        yield return null;
    }
}
