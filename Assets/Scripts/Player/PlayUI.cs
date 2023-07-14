using TMPro;
using UnityEngine;

public class PlayUI : MonoBehaviour
{
    public static PlayUI Instance;
    [Header("Throw Parameters")]
    [SerializeField] TMP_Text _massText;
    [SerializeField] TMP_Text _gravityText;
    [SerializeField] TMP_Text _throwPowerText;
    [SerializeField] TMP_Text _explosionForceText;
    [SerializeField] TMP_Text _explosionRadiusText;

    [Header("Indicator")]
    [SerializeField] TMP_Text _bombText;
    [SerializeField] TMP_Text _knifeText;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        StartingGameParameters();
    }

    private void StartingGameParameters()
    {
        _massText.text = ThrowSettings.Instance.Mass.ToString();
        _gravityText.text = ThrowSettings.Instance.Gravity.ToString();
        _throwPowerText.text = ThrowSettings.Instance.ThrowPower.ToString();
        _explosionForceText.text = ThrowSettings.Instance.ExplosionForce.ToString();
        _explosionRadiusText.text = ThrowSettings.Instance.ExplosionRadius.ToString();
    }

    /// <summary>
    /// ParameterID: 0=Mass, 1=Garvity, 2=Throw Power, 3=ExplosionForce, 4=ExplosionRadius
    /// </summary>
    /// <param name="parameterID"></param>
    /// <param name="newNumber"></param>
    public void UpadteUI(int parameterID, float newNumber)
    {
        switch (parameterID)
        {
            case 0: _massText.text = newNumber.ToString(); break;
            case 1: _gravityText.text = newNumber.ToString(); break;
            case 2: _throwPowerText.text = newNumber.ToString(); break;
            case 3: _massText.text = newNumber.ToString(); break;
            case 4: _explosionForceText.text = newNumber.ToString(); break;
            case 5: _explosionRadiusText.text = newNumber.ToString(); break;
        }

    }
}
