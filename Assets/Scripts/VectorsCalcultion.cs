using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class VectorsCalcultion : MonoBehaviour
{
    [Header("UI Objects")]
    [SerializeField] private TextMeshProUGUI _vector1Text;
    [SerializeField] private TextMeshProUGUI _vector2Text;
    [SerializeField] private TextMeshProUGUI _vector3Text;
    [SerializeField] private TextMeshProUGUI _v1AndV2NetForceText;
    [SerializeField] private TextMeshProUGUI _resultText;
    [SerializeField] private TMP_InputField _inputFieldX;
    [SerializeField] private TMP_InputField _inputFieldY;

    [Header("Settings")]
    [SerializeField] private float _maxValue;
    [SerializeField] private float _minValue;

    private Vector3 _vector1;
    private Vector3 _vector2;
    private Vector3 _vector3;
    private Vector3 _v1AndV2NetForce;
    private Vector3 _result;
    private Vector3 _playerAnswer;

    public void GenerateVectors(bool displayAnswer)
    {
        _vector1 = new Vector3(Random.Range(_minValue, _maxValue), Random.Range(_minValue, _maxValue), 0);
        _vector2 = new Vector3(Random.Range(_minValue, _maxValue), Random.Range(_minValue, _maxValue), 0);
        _result = _vector1 + _vector2;

        _vector1Text.text = $"Vector 1: {_vector1.x}   ,   {_vector1.y}";
        _vector2Text.text = $"Vector 2: {_vector2.x}   ,   {_vector2.y}";

        if (displayAnswer)
            _resultText.text = $"The answer is {_result}";
    }

    public void GenerateNetForecAndV3()
    {
        _vector1 = new Vector3(Random.Range(_minValue, _maxValue), Random.Range(_minValue, _maxValue), 0);
        _vector2 = new Vector3(Random.Range(_minValue, _maxValue), Random.Range(_minValue, _maxValue), 0);
        _vector3 = new Vector3(Random.Range(_minValue, _maxValue), Random.Range(_minValue, _maxValue), 0);
        _v1AndV2NetForce = _vector1 + _vector2;
        _result = _v1AndV2NetForce - _vector3;
        _vector3Text.text = $"Vector 3: {_vector3}";
        _v1AndV2NetForceText.text = $"The net force of V1+V2 is: {_v1AndV2NetForce}";
    }

    public void CheckAnswer()
    {
       _resultText.text = $"The answer is {_result}";
    }

}