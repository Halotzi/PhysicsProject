using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ThrowSettings : MonoBehaviour
{
    [SerializeField] private Transform _camera;
    [Range(0,100)]
    [SerializeField] private float _throwPower;
    [SerializeField] private ThrowingKnife _knifePrefab;
    [SerializeField] private ThrowingBomb _bombePrefab;

    [SerializeField] private Transform _throwPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
            ThrowKnife();

        if(Input.GetKeyDown(KeyCode.LeftShift))
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
