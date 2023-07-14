using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ThrowSettings : MonoBehaviour
{
    public static ThrowSettings Instance;

    [SerializeField] private Transform _camera;
    [Range(0,100)]
    [SerializeField] private ThrowingKnife _knifePrefab;
    [SerializeField] private ThrowingBomb _bombePrefab;
    [SerializeField] private Transform _throwPoint;
    
    [Header("Parameters")]
    [SerializeField] private float _throwPower;
    [SerializeField] private float _gravity;
    [SerializeField] private float _mass;
    [SerializeField] private float _explosionForce;
    [SerializeField] private float _explosionRadius;

    public float ThrowPower => _throwPower;
    public float Gravity => _gravity;
    public float Mass => _mass;
    public float ExplosionForce => _explosionForce;
    public float ExplosionRadius => _explosionRadius;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            ThrowKnife();

        if (Input.GetKeyDown(KeyCode.E))
            ThrowBomb();
    }

    public void ThrowKnife()
    {
        ThrowingKnife knife =  Instantiate(_knifePrefab, _throwPoint.position, _camera.rotation).GetComponent<ThrowingKnife>();
        knife.Throwing(_camera.rotation.x,_throwPower);
    }

    public void ThrowBomb()
    {
        ThrowingBomb grande = Instantiate(_bombePrefab, _throwPoint.position, _camera.rotation).GetComponent<ThrowingBomb>();
        grande.Throwing(_camera.rotation.x, _throwPower);
    }

}
