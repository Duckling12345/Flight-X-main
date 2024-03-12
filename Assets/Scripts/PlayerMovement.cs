using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public FixedJoystick joystick;
    public float SpeedMove = 3f;
    public CharacterController controller;

    public Transform InteractorSource;
    public float InteractRange;
    public bool Pressed;

 
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    public void Update()
    {
        Vector3 Move = transform.right * joystick.Horizontal + transform.forward * joystick.Vertical;
        controller.Move(Move * SpeedMove*Time.deltaTime);
        
        if (Pressed)
        {
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactObj))
                {
                    interactObj.Interact();  
                }
            }
        }
    }


}