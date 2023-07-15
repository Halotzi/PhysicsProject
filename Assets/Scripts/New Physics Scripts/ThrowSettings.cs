using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThrowSettings : MonoBehaviour
{
    public static ThrowSettings Instance;

    [SerializeField] private Transform _camera;
    [SerializeField] private ThrowingKnife _knifePrefab;
    [SerializeField] private ThrowingBomb _bombePrefab;
    [SerializeField] private Transform _throwPoint;
    
    [Header("Parameters")]
    [Range(0,100)]
    [SerializeField] private float _throwPower;
    [SerializeField] private float _gravity;
    [SerializeField] private float _mass;
    [SerializeField] private float _explosionForce;
    [SerializeField] private float _explosionRadius;

    [Header("PlayerInput")]

    [SerializeField] private InputActionAsset _inputActionAsset;
    [SerializeField] private PlayerInput _playerInput;

    public float ThrowPower => _throwPower;
    public float Gravity => _gravity;
    public float Mass => _mass;
    public float ExplosionForce => _explosionForce;
    public float ExplosionRadius => _explosionRadius;

    private void Awake()
    {
        Instance = this;
        _playerInput = new PlayerInput();
        _playerInput.Enable();
        RegisterEvents();
    }

    private void OnDestroy()
    {
        Unrigester();
    }

    private void RegisterEvents()
    {
        //Throwing
        _playerInput.Parameters.ThrowGranade.performed += ThrowBomb;
        _playerInput.Parameters.ThrowKnife.performed += ThrowKnife;

        //Mass
        _playerInput.Parameters.DecreaseMass.performed += DecreaseMass;
        _playerInput.Parameters.IncraseMass.performed += IncraseMass;
        //Gravity
        _playerInput.Parameters.DecreaseGravity.performed += DecreaseGravity;
        _playerInput.Parameters.IncraseGravity.performed += IncraseGravity;
        //Throw Power
        _playerInput.Parameters.DecreaseThrowPower.performed += DecreaseThrowPower;
        _playerInput.Parameters.IncraseThrowPower.performed += IncraseThrowPower;
        //Explosion Force
        _playerInput.Parameters.DecreaseExplosionForce.performed += DecreaseExplosionForce;
        _playerInput.Parameters.IncraseExplosionForce.performed += IncraseExplosionForce;
        //Object Radius
        _playerInput.Parameters.DecreaseObjectRadius.performed += DecreaseObjectRadius;
        _playerInput.Parameters.IncraseObjectRadius.performed += IncraseObjectRadius;
    }

    public void ThrowKnife(InputAction.CallbackContext action)
    {
        ThrowingKnife knife =  Instantiate(_knifePrefab, _throwPoint.position, _camera.rotation).GetComponent<ThrowingKnife>();
        knife.Throwing(_camera.rotation.x,_throwPower);
    }

    public void ThrowBomb(InputAction.CallbackContext action)
    {
        ThrowingBomb grande = Instantiate(_bombePrefab, _throwPoint.position, _camera.rotation).GetComponent<ThrowingBomb>();
        grande.Throwing(_camera.rotation.x, _throwPower);
    }

    public void DecreaseMass(InputAction.CallbackContext action)
    {
        _mass--;
        PlayUI.Instance.UpadteUI(0, _mass);
    }

    private void IncraseMass(InputAction.CallbackContext obj)
    {
        _mass++;
        PlayUI.Instance.UpadteUI(0, _mass);
    }

    private void DecreaseGravity(InputAction.CallbackContext obj)
    {
        _gravity--;
        PlayUI.Instance.UpadteUI(1, _gravity);
    }

    private void IncraseGravity(InputAction.CallbackContext obj)
    {
        _gravity++;
        PlayUI.Instance.UpadteUI(1, _gravity);
    }

    private void DecreaseThrowPower(InputAction.CallbackContext obj)
    {
        _throwPower--;
        PlayUI.Instance.UpadteUI(2, _throwPower);
    }

    private void IncraseThrowPower(InputAction.CallbackContext obj)
    {
        _throwPower++;
        PlayUI.Instance.UpadteUI(2, _throwPower);
    }

    private void DecreaseExplosionForce(InputAction.CallbackContext obj)
    {
        _explosionForce--;
        PlayUI.Instance.UpadteUI(3, _explosionForce);
    }

    private void IncraseExplosionForce(InputAction.CallbackContext obj)
    {
        _explosionForce++;
        PlayUI.Instance.UpadteUI(3, _explosionForce);
    }

    private void DecreaseObjectRadius(InputAction.CallbackContext obj)
    {
        _explosionRadius--;
        PlayUI.Instance.UpadteUI(4, _explosionRadius);
    }

    private void IncraseObjectRadius(InputAction.CallbackContext obj)
    {
        _explosionRadius++;
        PlayUI.Instance.UpadteUI(4, _explosionRadius);
    }

    private void Unrigester()
    {
        //Throwing
        _playerInput.Parameters.ThrowGranade.performed -= ThrowBomb;
        _playerInput.Parameters.ThrowKnife.performed -= ThrowKnife;

        //Mass
        _playerInput.Parameters.DecreaseMass.performed -= DecreaseMass;
        _playerInput.Parameters.IncraseMass.performed -= IncraseMass;
        //Gravity
        _playerInput.Parameters.DecreaseGravity.performed -= DecreaseGravity;
        _playerInput.Parameters.IncraseGravity.performed -= IncraseGravity;
        //Throw Power
        _playerInput.Parameters.DecreaseThrowPower.performed -= DecreaseThrowPower;
        _playerInput.Parameters.IncraseThrowPower.performed -= IncraseThrowPower;
        //Explosion Force
        _playerInput.Parameters.DecreaseExplosionForce.performed -= DecreaseExplosionForce;
        _playerInput.Parameters.IncraseExplosionForce.performed -= IncraseExplosionForce;
        //Object Radius
        _playerInput.Parameters.DecreaseObjectRadius.performed -= DecreaseObjectRadius;
        _playerInput.Parameters.IncraseObjectRadius.performed -= IncraseObjectRadius;
    }
}
