using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAnimationController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayDoorOpen()
    {
        animator.Play("DoorOpen");
    }
}
