using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseTwo : StateMachineBehaviour
{

// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //call coroutine so attack will end in a set amount of random time ~ cant do that in state behavior
        //enable fire instantiation and call time script here through other script
        //when fire instantiation is done overall, will exit state
        //OKAY we adding a movement script so using the transform is easier, done with statemachine
        animator.SetBool("doneWithFire", false);
        animator.GetComponent<FireInstantiation>().enabled = true;
        animator.GetComponent<FireMovement>().enabled = true;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        float _speed = 5f;
        Vector3 enemy_pos = EnemySingleton.Enemy.transform.position;
        Vector3 player_pos = PlayerSingleton.player.transform.position;
        Vector3 direction = (player_pos - enemy_pos).normalized;
        EnemySingleton.Enemy.transform.position += direction * _speed * Time.deltaTime;
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<FireInstantiation>().enabled = false;
        animator.GetComponent<FireMovement>().enabled = false;
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
