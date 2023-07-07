using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    private Rigidbody _rigidbody;
    [SerializeField] private Transform _orientation;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _groundDrag;

    private float _horizontalInput;
    private float _verticalInput;
    private Vector3 _moveDirection;

    [Header("Jumping")]
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _jumpCooldown;
    [SerializeField] private float _airMultiplier;
    private bool _isReadyToJump;

    [Header("Keybinds")]
    [SerializeField] private KeyCode _jumpKeyCode = KeyCode.Space;

    [Header("Ground Check")]
    [SerializeField] private float _playerHeight;
    [SerializeField] public LayerMask Ground;
    private bool _isGrounded;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        //_rigidbody = new Rigidbody3D(1f, transform.position);
        _rigidbody.freezeRotation = true;
        _isReadyToJump = true;
    }

    private void Update()
    {
        
        //Ground check
        _isGrounded = Physics.Raycast(transform.position, Vector3.down, _playerHeight * 0.5f + 0.3f, Ground);
        GetInput();
        SpeedControl();
        //Handle drag
        if (_isGrounded)
            _rigidbody.drag = _groundDrag;

        else
            _rigidbody.drag = 0;
    }

    private void FixedUpdate()
    {
        //_rigidbody.UpdateRigidbody(Time.deltaTime);
        MovePlayer();
    }

    private void GetInput()
    {
        _horizontalInput = Input.GetAxisRaw("Horizontal");
        _verticalInput = Input.GetAxisRaw("Vertical");

        if(Input.GetKey(_jumpKeyCode)&&_isReadyToJump&&_isGrounded)
        {
            _isReadyToJump = false;
            Jump();
            Invoke(nameof(ResetJump), _jumpCooldown);
        }
    }

    private void MovePlayer()
    {
        //calculate movement direction
        _moveDirection = _orientation.forward * _verticalInput + _orientation.right * _horizontalInput;

        //on ground
        if(_isGrounded)
        _rigidbody.AddForce(_moveDirection.normalized * _moveSpeed * 10f, UnityEngine.ForceMode.Force);

        else if(!_isGrounded)
            _rigidbody.AddForce(_moveDirection.normalized * _moveSpeed * 10f* _airMultiplier, UnityEngine.ForceMode.Force);


    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(_rigidbody.velocity.x, 0f, _rigidbody.velocity.z);

        //limit velocity if needed
        if(flatVel.magnitude > _moveSpeed) 
        {
            Vector3 limitedVel = flatVel.normalized *  _moveSpeed;
            _rigidbody.velocity = new Vector3(limitedVel.x, _rigidbody.velocity.y, limitedVel.z);
        }
    }

    private void Jump()
    {
        _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, 0f, _rigidbody.velocity.z);
        _rigidbody.AddForce(transform.up * _jumpForce, UnityEngine.ForceMode.Impulse);
    }

    private void ResetJump()
    {
        _isReadyToJump = true;
    }
}
