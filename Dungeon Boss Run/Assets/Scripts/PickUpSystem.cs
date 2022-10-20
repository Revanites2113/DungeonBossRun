using System.Collections;
using UnityEngine;

public class PickUpSystem : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject pickupHealth;
    [SerializeField] private GameObject pickupAttack;
    void Start()
    {
        //constant coroutine instans until five items are spawned
        StartCoroutine("InstanPickup");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator InstanPickup()
    {
        int count = 5;
        while (count > 0)
        {
            yield return new WaitForSeconds(Random.Range(10f, 45f));
            randInt();
            count -= 1;
        }
        yield return null;
    }

    private void randInt()
    {
        int choice = 0;
        choice = Random.Range(0, 2);
        if (choice == 0)
        {
            Instantiate(pickupHealth);
        }
        else
        {
            Instantiate(pickupAttack);
        }
    }
}
