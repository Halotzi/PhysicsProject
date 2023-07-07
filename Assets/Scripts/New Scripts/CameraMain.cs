using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraMain : MonoBehaviour
{
    public Transform body;
    public float _sensitivity;
    float _mouseX, _mouseY;
    float xrotation;

    public virtual void Start()
    {
        transform.rotation = new Quaternion(0, 0, 0, 0);
    }
    public virtual void Update()
    {
        PlayerInput();
    }
    public virtual void PlayerInput()
    {
        _mouseX = Input.GetAxis("Mouse X") * _sensitivity * Time.deltaTime;
        _mouseY = Input.GetAxis("Mouse Y") * _sensitivity * Time.deltaTime;

        xrotation -= _mouseY;
        xrotation = Mathf.Clamp(xrotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xrotation, 0, 0);
        body.Rotate(Vector3.up * _mouseX);
    }
}
