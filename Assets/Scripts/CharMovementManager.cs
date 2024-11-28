using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMovementManager : MonoBehaviour
{

    public VariableJoystick joystick;
    public Canvas inputCanvas;
    public Animator animator;
    public bool isJoystick;
    public float movementSpeed = 5;
    public float rotationSpeed = 5;
    private CharacterController controller;




    private void Start()
    {
        controller = GetComponent<CharacterController>();
        EnableJoystickInput();
    }

    public void EnableJoystickInput()
    {
        isJoystick= true;
        inputCanvas.gameObject.SetActive(true);
    }
    public void Update()
    {
        if (isJoystick)
        {
            var movementDirection = new Vector3(joystick.Direction.x, 0.0f, joystick.Direction.y);
            controller.SimpleMove(movementDirection * movementSpeed);

            if (movementDirection.sqrMagnitude <= 0 )
            {
                animator.SetBool("isMoving",false);
                return;
            }
            animator.SetBool("isMoving", true);
            var targetDirection = Vector3.RotateTowards(controller.transform.forward, movementDirection, rotationSpeed * Time.deltaTime, 0.0f);
            controller.transform.rotation = Quaternion.LookRotation(targetDirection);

        }
    }

    public void StopCharacter()
    {
        isJoystick = false;
        animator.SetBool("isMoving", false);
    }
}
