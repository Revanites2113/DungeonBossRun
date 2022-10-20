using UnityEngine;

public class PlayerSingleton : MonoBehaviour
{
    //general player info for world like HP and defense
    //also setting up player as a singleton
    public static PlayerSingleton player;
    [SerializeField] Animator _animator;

    public int health = 3;
    public bool isPowerUp;
    

    void Start()
    {
        player = this;
    }
    void Update()
    {
        if (health <= 0)
        {
            //game over here using animation, screen and such (one of the last things honestly)
            //load screen after animation and coroutine to let animation finish
            _animator.SetBool("isDead", true);
        }
    }
}
