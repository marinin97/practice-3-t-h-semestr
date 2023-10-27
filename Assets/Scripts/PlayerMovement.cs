using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float _speed = 2f;
    private float _boost = 10f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movement = transform.right * _speed;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                movement = transform.right * _boost;
            }
        }

        _rigidbody.velocity = movement;


    }
}
