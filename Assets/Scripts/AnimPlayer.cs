using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPlayer : MonoBehaviour
{
    public Animator Animator;
    private bool _isWalking = false;
    private bool _isRunning = false;

    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                _isRunning = true;
            }
            else
            {
                _isRunning = false;
            }

            _isWalking = true;
        }
        else
        {
            _isWalking = false;
        }
        Animator.SetBool("isWalking", _isWalking);
        Animator.SetBool("isRunning", _isRunning);
    }
}
