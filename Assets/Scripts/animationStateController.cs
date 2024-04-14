using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{   Animator animator;
   
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()


    {

        bool walkingF = Input.GetKey("w");
        bool walkingB = Input.GetKey("s");
        bool walkingR = Input.GetKey("d");
        bool walkingL = Input.GetKey("a");
        bool strike = Input.GetKey("l");

          if (walkingF || walkingB || walkingL || walkingR){

        animator.SetBool("IsWalking",true); //walking animation
        }

        if (!(walkingF || walkingB || walkingL || walkingR)){

        animator.SetBool("IsWalking",false); //walking animagtion stop
        }


        if (Input.GetButtonDown("Strike"))
        {
            animator.Play("MeleeAttack_OneHanded"); //strike animation
        }

    }
}
  
