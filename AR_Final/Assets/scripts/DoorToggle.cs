using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorToggle : MonoBehaviour
{
    public Animator animator;

    public void ToggleDoor()
    {
        if (animator == null)
        {
            Debug.LogWarning("Animator not assigned.");
            return;
        }

        bool currentState = animator.GetBool("Open");
        animator.SetBool("Open", !currentState);
    }
}

