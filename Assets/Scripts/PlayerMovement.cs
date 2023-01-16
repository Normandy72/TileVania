using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Vector2 moveInpit;
    void Start()
    {
        
    }

    void Update()
    {
    
    }

    void OnMove(InputValue value)
    {
       moveInpit = value.Get<Vector2>();
    }
}
