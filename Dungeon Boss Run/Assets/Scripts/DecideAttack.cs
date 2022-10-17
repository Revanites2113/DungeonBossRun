using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecideAttack : StateMachineBehaviour
{
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //okay we gonna set a rand int for the next attack based on bool values and phases
        int min = 0;
        int max;
        if (animator.GetBool("isPhase2"))
        {
            max = 2;
            animator.SetInteger("randAttackInt", Random.Range(min, max));
        }
        else if (animator.GetBool("isPhase3"))
        {
            max = 3;
            animator.SetInteger("randAttackInt", Random.Range(min, max));
        }
        else
        {
            animator.SetInteger("randAttackInt", 0);
        }
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

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
