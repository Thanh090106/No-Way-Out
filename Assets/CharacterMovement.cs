using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
   
    CharacterController characterController;
    public float moveSpeed = 5f;
    private Vector3 moveDirection;
    public float sprint = 40f;
    public float sprintTime = 5f;
    public float speed = 0;
    
    
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
      float forwardInput = Input.GetAxis("Vertical");
      float rightInput = Input.GetAxis("Horizontal");
      Vector3 forward = Camera.main.transform.forward;
      Vector3 right = Camera.main.transform.right;


        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();
        
        if(Input.GetKey(KeyCode.LeftShift) && sprintTime > 1)
        {
            
            speed = sprint;
            sprintTime = sprintTime - 1 * Time.deltaTime;
            sprintTime = Mathf.Clamp(sprintTime,0f,5f);
        }
        else if(!Input.GetKey(KeyCode.LeftShift))
        {
            
            speed = moveSpeed;
            sprintTime = sprintTime + 1 * Time.deltaTime;
            sprintTime = Mathf.Clamp(sprintTime,0f,5f);
        }
        else
        {
            
            speed = moveSpeed;
        }
        
       
        
       
        
        moveDirection = (forwardInput * forward) + (rightInput * right);
        moveDirection.Normalize();
        moveDirection.y = -98f * Time.deltaTime;
        characterController.Move(moveDirection * speed * Time.deltaTime);
        
    }
    
    
}

