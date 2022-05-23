using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent (typeof (Controller2D))]
public class PlayerController : MonoBehaviour
{
    Vector2 velocity;
    private float moveSpeed = 3f;

 
    Controller2D controller;
    Animator anim;

    private void Start()
    {

        controller = GetComponent<Controller2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {

        controller.Move(velocity * Time.deltaTime);


    }

   private void LateUpdate()
    {
        Vector2 inputDirection = value.ReadValue<Vector2>();
        velocity.x = inputDirection.x * moveSpeed;
        velocity.y = inputDirection.y * moveSpeed;

    }


    /*private void LateUpdate()
    {
        if(directionX == 0 && directionY == 0)
        {
            anim.SetFloat("PosX", prevX);
            anim.SetFloat("PosY", prevY);
        }
        else
        {
            anim.SetFloat("PosX", directionX);
            anim.SetFloat("PosY", directionY);
            prevX = directionX;
            prevY = directionY;

        }
        
    }

    public void Move(InputAction.CallbackContext value)
    {
        Vector2 moveDirection = value.ReadValue<Vector2>();

        directionX =  moveDirection.x;
        directionY =  moveDirection.y;
    }
    
}
