using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //this script will also handle transitions between animation states (still all just movement related)
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private Animator movementAni;
    private Vector3 _moveDir;
    private int _thrust = 10;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        int moveX = 0;
        int moveY = 0;
        
        //resetting animation state every frame so not stuck in states
        movementAni.SetBool("isMoving", false);
        movementAni.SetBool("isRight", false);
        movementAni.SetBool("isLeft", false);
        movementAni.SetBool("isAttacking", false);
        
        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1;
            movementAni.SetBool("isRight", true);
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1;
            movementAni.SetBool("isLeft", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1;
            movementAni.SetBool("isRight", true);
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1;
            movementAni.SetBool("isLeft", true);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            movementAni.SetBool("isAttacking", true);
        }

        _moveDir = new Vector3(moveX, moveY, 0);
        playerRb.MovePosition(transform.position + (_moveDir * Time.deltaTime * _thrust));

        if (_moveDir != Vector3.zero)
        {
            movementAni.SetBool("isMoving", true);
        }
    }
}
