using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassengerMovement : MonoBehaviour
{
    private float Gravity = -9.81f;
    public float groundDistance = 0.3f;
    public Transform Ground;
    public LayerMask layermask;
    Vector3 velocity;
    public bool isGround;
    public Animator Animation;

    public void Update()
    {
        isGround = Physics.CheckSphere(Ground.position, groundDistance, layermask);

        if (isGround && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        Animation.Play("Evacuation (Passengers)");
    }
}
