using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField, Range(1f,10f)] private float _moveSpeed = 5f;
    [SerializeField] private Rigidbody2D _rb;
    private InputAction _move;
    private PlayerInput _playerInput;
    private Vector2 movement;
    
    void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _move = _playerInput.actions["Move"];
    }

    void Update()
    {
        PlayerMovement();
    }
    void FixedUpdate()
    {
        _rb.linearVelocity = movement * _moveSpeed;
    }
    
    void PlayerMovement()
    {
        movement = _move.ReadValue<Vector2>();
        
        
    }
}
