using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3.0F;

    CharacterController characterController;
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 Move = new Vector3(inputX, 0, inputY);
        
        characterController.SimpleMove(Move * speed);
    }
}
