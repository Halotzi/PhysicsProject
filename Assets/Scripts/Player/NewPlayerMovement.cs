using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewPlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float _walkSpeed;
    [SerializeField] float gravity;
    float _horizontal, _vertical;
    Vector3 move;

    private void Start()
    {
        controller= GetComponent<CharacterController>();
    }
    private void Update()
    {
        PlayerInput();
    }
    void PlayerInput()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");
        if(_horizontal!=0 || _vertical!=0) 
        {
            Move();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene(1);
    }
    private void Move()
    {
        move= (transform.right* _horizontal + transform.forward*_vertical)*_walkSpeed*Time.deltaTime;
        move.y+=gravity*Time.deltaTime;
        controller.Move(move);
    }
}
