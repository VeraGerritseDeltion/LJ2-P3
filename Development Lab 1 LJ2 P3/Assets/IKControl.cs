﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class IKControl : MonoBehaviour {

    public Animator animator;

    public bool ikActive = false;
    public Transform rightHandObj = null;
    public Transform lookTarget;
    

    void Start()
    {
        //lookTarget = GameObject.Find("LookTarget").transform;
        animator = GetComponent<Animator>();
    }

    //a callback for calculating IK
    void OnAnimatorIK()
    {
        if (true)
        {

            //if the IK is active, set the position and rotation directly to the goal. 
            if (true)
            {

                // Set the look target position, if one has been assigned
                if (true)
                {
                    animator.SetLookAtWeight(1);
                    animator.SetLookAtPosition(Camera.main.transform.position);
                }

                // Set the right hand target position and rotation, if one has been assigned
                if (rightHandObj != null)
                {
                    //animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1);
                    //animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1);
                    //animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandObj.position);
                    //animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandObj.rotation);
                }

            }

            //if the IK is not active, set the position and rotation of the hand and head back to the original position
            else
            {
                //animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 0);
                //animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 0);
                //animator.SetLookAtWeight(0);
            }
        }
    }
}