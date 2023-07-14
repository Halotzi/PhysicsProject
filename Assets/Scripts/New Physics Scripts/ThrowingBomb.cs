using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowingBomb : MonoBehaviour
{
    [SerializeField] private float _powerZ;
    [SerializeField] private float _powerY;
    [SerializeField] private float _gravity;
    [SerializeField] private float _mass;
    [SerializeField] private float _explosionForce;
    [SerializeField] private float _explosionRadius;
    [SerializeField] private LayerMask _effectedObject;



    private Vector3 _stoppingPosition;
    private bool _inMovement = true;
    private float _z;
    private float _y;
    private float _time;

    private void Awake()
    {
        _mass = ThrowSettings.Instance.Mass;
        _gravity = ThrowSettings.Instance.Mass;
    }
    public void Throwing(float angle, float power)
    {
        float _angle = Mathf.Deg2Rad * angle; //Converting the angle to radian. Im using the radian to find out sic/cos/tan of the angle to give value for power x/y
        _powerZ = power * Mathf.Cos(_angle); //Im using cos for the horizontal 
        _powerY = power * Mathf.Cos(_angle); //Im using cos for the vertical
    }

    private void Update()
    {
        if ((_powerZ != 0 || _powerY != 0) && _inMovement)
        {
            _time += Time.deltaTime;
            MoveObject();
        }

        else
        {
            transform.position = _stoppingPosition;
            _time = 0;
        }
    }

    public void MoveObject()
    {
        float pullDown = _gravity * _mass;
        _z += _powerZ * Time.deltaTime;
        _y = (_powerY - 0.5f * pullDown * Mathf.Pow(_time, 2)) * Time.deltaTime;
        transform.Translate(new Vector3(0, _y, _z) * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        _inMovement = false;
        _stoppingPosition = transform.position;
        Explode();
    }

    private void Explode()
    {
        UnityEngine.Collider[] objectsInRange = Physics.OverlapSphere(transform.position, _explosionRadius, _effectedObject); //Taking all the Component from the sphere  radius from specific layer

        for (int i = 0; i < objectsInRange.Length; i++)
        {
            // custom explosionForce
            Vector3 objectPos = objectsInRange[i].transform.position;

            // calculate force direction
            Vector3 forceDirection = (objectPos - transform.position).normalized;

            // apply force to object in range
            objectsInRange[i].GetComponent<ExploedCube>().ExplostionForce(forceDirection, _explosionForce);
        }
    }
}
