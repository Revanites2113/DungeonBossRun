using UnityEngine;

public class FireMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private int _speed = 10000;
    [SerializeField] private GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, Time.deltaTime * _speed);
    }
}
