using UnityEngine;

public class ExploedCube : MonoBehaviour
{
    [SerializeField] float _timeForMove;

    private float _currentTime = 0;
    private Vector3 _direction;
    private float _exploedForce;

    bool _exploed = false;
    public void ExplostionForce(Vector3 direction, float exploedForce)
    {
        _currentTime = 0;
        _exploedForce = exploedForce;
        _direction = direction;
        _exploed = true;
    }

    private void Update()
    {
        if (_exploed)
            StartMoving();

    }
    private void StartMoving()
    {
        transform.Translate(_direction * _exploedForce * Time.deltaTime);
        _currentTime += Time.deltaTime;
        if (_currentTime >= _timeForMove)
            _exploed = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        _exploed = false;
    }
}
