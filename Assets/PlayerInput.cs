//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Parameters"",
            ""id"": ""70de5006-62b9-43d7-b9c6-b30564b049fb"",
            ""actions"": [
                {
                    ""name"": ""ThrowGranade"",
                    ""type"": ""Button"",
                    ""id"": ""ed67fdab-afbe-4599-a2a4-4206d70cab5a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ThrowKnife"",
                    ""type"": ""Button"",
                    ""id"": ""3371c16e-3842-45f3-b090-e2e94827c62f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DecreaseMass"",
                    ""type"": ""Button"",
                    ""id"": ""bfc5e360-083e-4439-a4b0-0be0d8af698d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DecreaseGravity"",
                    ""type"": ""Button"",
                    ""id"": ""eb46cebb-ffea-4f30-aefb-31c4a8c6fd53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DecreaseThrowPower"",
                    ""type"": ""Button"",
                    ""id"": ""94b231b1-3d18-41e5-afde-e693a6cacfe7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DecreaseExplosionForce"",
                    ""type"": ""Button"",
                    ""id"": ""e655fd9f-3cb2-42fd-880a-626065ba6342"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DecreaseObjectRadius"",
                    ""type"": ""Button"",
                    ""id"": ""0a34155b-0f59-4b35-9f2a-29830cea391c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""IncraseMass"",
                    ""type"": ""Button"",
                    ""id"": ""9eb84517-d90c-4391-bbd0-14560a8a4a72"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""IncraseGravity"",
                    ""type"": ""Button"",
                    ""id"": ""9c92aa59-3672-4f17-a04c-9441b8fff96e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""IncraseThrowPower"",
                    ""type"": ""Button"",
                    ""id"": ""4883a41c-fc21-4565-a6b9-5f243d5638a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""IncraseExplosionForce"",
                    ""type"": ""Button"",
                    ""id"": ""bcb7df18-572e-4943-94d0-c1d0379ad9da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""IncraseObjectRadius"",
                    ""type"": ""Button"",
                    ""id"": ""1a80f889-061a-44e9-856a-e7b0e209610b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e244c2c7-a46a-496d-a360-cebd18329e18"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowGranade"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f006ac23-c0aa-4d5c-8592-2a5217a29612"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowKnife"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a25b66fd-10a9-4dd3-b22a-4be924ce020c"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecreaseMass"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0154f1ea-ebd7-4c99-9f18-41795d6d8ee1"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecreaseMass"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f6c2d3b-9103-443e-9e51-d7a95a8acf09"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncraseMass"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f3b2fe8-cb2a-42af-b942-352c3f04c201"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncraseMass"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49f6e1c9-a7cf-4675-ac1b-7a21bbb28bf0"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecreaseGravity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d198bb4b-eae9-44c7-bae0-8bf993e09488"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecreaseGravity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9db400a-10d1-4bbc-9d69-1b8dd21bdeb5"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncraseGravity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7e7b17c-3856-47ed-9c38-1b825fc308d0"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncraseGravity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""553f6018-69b7-4269-b265-e206332b41f6"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecreaseThrowPower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc825b82-ec86-4a5d-ac00-4408192506d8"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecreaseThrowPower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""070a9d18-0bb0-4a2e-a4a4-ac25914e8d0f"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncraseThrowPower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e9e86ce-66c6-414a-9ebe-aa3697902606"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncraseThrowPower"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad24166c-4541-4295-addb-6f0c964bbc45"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecreaseExplosionForce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a463775-cc39-4e2d-99b7-64c33f1eeac9"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecreaseExplosionForce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cc2cc72-b66c-4eff-bda4-f521010fe5fc"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncraseExplosionForce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07cb9848-6311-4aa4-8ae5-9572b93f00ef"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncraseExplosionForce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f9ab181-0908-4d75-8576-0620deb9b1c7"",
                    ""path"": ""<Keyboard>/numpad9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecreaseObjectRadius"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af4ef8c4-1699-4f95-ac9a-1637b9395b63"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DecreaseObjectRadius"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d37c0c4-6cfc-40a4-8bd5-1831cc4fa12d"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncraseObjectRadius"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8af79f5e-ae63-4adc-a423-ad3e06ef5fda"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""IncraseObjectRadius"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Parameters
        m_Parameters = asset.FindActionMap("Parameters", throwIfNotFound: true);
        m_Parameters_ThrowGranade = m_Parameters.FindAction("ThrowGranade", throwIfNotFound: true);
        m_Parameters_ThrowKnife = m_Parameters.FindAction("ThrowKnife", throwIfNotFound: true);
        m_Parameters_DecreaseMass = m_Parameters.FindAction("DecreaseMass", throwIfNotFound: true);
        m_Parameters_DecreaseGravity = m_Parameters.FindAction("DecreaseGravity", throwIfNotFound: true);
        m_Parameters_DecreaseThrowPower = m_Parameters.FindAction("DecreaseThrowPower", throwIfNotFound: true);
        m_Parameters_DecreaseExplosionForce = m_Parameters.FindAction("DecreaseExplosionForce", throwIfNotFound: true);
        m_Parameters_DecreaseObjectRadius = m_Parameters.FindAction("DecreaseObjectRadius", throwIfNotFound: true);
        m_Parameters_IncraseMass = m_Parameters.FindAction("IncraseMass", throwIfNotFound: true);
        m_Parameters_IncraseGravity = m_Parameters.FindAction("IncraseGravity", throwIfNotFound: true);
        m_Parameters_IncraseThrowPower = m_Parameters.FindAction("IncraseThrowPower", throwIfNotFound: true);
        m_Parameters_IncraseExplosionForce = m_Parameters.FindAction("IncraseExplosionForce", throwIfNotFound: true);
        m_Parameters_IncraseObjectRadius = m_Parameters.FindAction("IncraseObjectRadius", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Parameters
    private readonly InputActionMap m_Parameters;
    private List<IParametersActions> m_ParametersActionsCallbackInterfaces = new List<IParametersActions>();
    private readonly InputAction m_Parameters_ThrowGranade;
    private readonly InputAction m_Parameters_ThrowKnife;
    private readonly InputAction m_Parameters_DecreaseMass;
    private readonly InputAction m_Parameters_DecreaseGravity;
    private readonly InputAction m_Parameters_DecreaseThrowPower;
    private readonly InputAction m_Parameters_DecreaseExplosionForce;
    private readonly InputAction m_Parameters_DecreaseObjectRadius;
    private readonly InputAction m_Parameters_IncraseMass;
    private readonly InputAction m_Parameters_IncraseGravity;
    private readonly InputAction m_Parameters_IncraseThrowPower;
    private readonly InputAction m_Parameters_IncraseExplosionForce;
    private readonly InputAction m_Parameters_IncraseObjectRadius;
    public struct ParametersActions
    {
        private @PlayerInput m_Wrapper;
        public ParametersActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @ThrowGranade => m_Wrapper.m_Parameters_ThrowGranade;
        public InputAction @ThrowKnife => m_Wrapper.m_Parameters_ThrowKnife;
        public InputAction @DecreaseMass => m_Wrapper.m_Parameters_DecreaseMass;
        public InputAction @DecreaseGravity => m_Wrapper.m_Parameters_DecreaseGravity;
        public InputAction @DecreaseThrowPower => m_Wrapper.m_Parameters_DecreaseThrowPower;
        public InputAction @DecreaseExplosionForce => m_Wrapper.m_Parameters_DecreaseExplosionForce;
        public InputAction @DecreaseObjectRadius => m_Wrapper.m_Parameters_DecreaseObjectRadius;
        public InputAction @IncraseMass => m_Wrapper.m_Parameters_IncraseMass;
        public InputAction @IncraseGravity => m_Wrapper.m_Parameters_IncraseGravity;
        public InputAction @IncraseThrowPower => m_Wrapper.m_Parameters_IncraseThrowPower;
        public InputAction @IncraseExplosionForce => m_Wrapper.m_Parameters_IncraseExplosionForce;
        public InputAction @IncraseObjectRadius => m_Wrapper.m_Parameters_IncraseObjectRadius;
        public InputActionMap Get() { return m_Wrapper.m_Parameters; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ParametersActions set) { return set.Get(); }
        public void AddCallbacks(IParametersActions instance)
        {
            if (instance == null || m_Wrapper.m_ParametersActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ParametersActionsCallbackInterfaces.Add(instance);
            @ThrowGranade.started += instance.OnThrowGranade;
            @ThrowGranade.performed += instance.OnThrowGranade;
            @ThrowGranade.canceled += instance.OnThrowGranade;
            @ThrowKnife.started += instance.OnThrowKnife;
            @ThrowKnife.performed += instance.OnThrowKnife;
            @ThrowKnife.canceled += instance.OnThrowKnife;
            @DecreaseMass.started += instance.OnDecreaseMass;
            @DecreaseMass.performed += instance.OnDecreaseMass;
            @DecreaseMass.canceled += instance.OnDecreaseMass;
            @DecreaseGravity.started += instance.OnDecreaseGravity;
            @DecreaseGravity.performed += instance.OnDecreaseGravity;
            @DecreaseGravity.canceled += instance.OnDecreaseGravity;
            @DecreaseThrowPower.started += instance.OnDecreaseThrowPower;
            @DecreaseThrowPower.performed += instance.OnDecreaseThrowPower;
            @DecreaseThrowPower.canceled += instance.OnDecreaseThrowPower;
            @DecreaseExplosionForce.started += instance.OnDecreaseExplosionForce;
            @DecreaseExplosionForce.performed += instance.OnDecreaseExplosionForce;
            @DecreaseExplosionForce.canceled += instance.OnDecreaseExplosionForce;
            @DecreaseObjectRadius.started += instance.OnDecreaseObjectRadius;
            @DecreaseObjectRadius.performed += instance.OnDecreaseObjectRadius;
            @DecreaseObjectRadius.canceled += instance.OnDecreaseObjectRadius;
            @IncraseMass.started += instance.OnIncraseMass;
            @IncraseMass.performed += instance.OnIncraseMass;
            @IncraseMass.canceled += instance.OnIncraseMass;
            @IncraseGravity.started += instance.OnIncraseGravity;
            @IncraseGravity.performed += instance.OnIncraseGravity;
            @IncraseGravity.canceled += instance.OnIncraseGravity;
            @IncraseThrowPower.started += instance.OnIncraseThrowPower;
            @IncraseThrowPower.performed += instance.OnIncraseThrowPower;
            @IncraseThrowPower.canceled += instance.OnIncraseThrowPower;
            @IncraseExplosionForce.started += instance.OnIncraseExplosionForce;
            @IncraseExplosionForce.performed += instance.OnIncraseExplosionForce;
            @IncraseExplosionForce.canceled += instance.OnIncraseExplosionForce;
            @IncraseObjectRadius.started += instance.OnIncraseObjectRadius;
            @IncraseObjectRadius.performed += instance.OnIncraseObjectRadius;
            @IncraseObjectRadius.canceled += instance.OnIncraseObjectRadius;
        }

        private void UnregisterCallbacks(IParametersActions instance)
        {
            @ThrowGranade.started -= instance.OnThrowGranade;
            @ThrowGranade.performed -= instance.OnThrowGranade;
            @ThrowGranade.canceled -= instance.OnThrowGranade;
            @ThrowKnife.started -= instance.OnThrowKnife;
            @ThrowKnife.performed -= instance.OnThrowKnife;
            @ThrowKnife.canceled -= instance.OnThrowKnife;
            @DecreaseMass.started -= instance.OnDecreaseMass;
            @DecreaseMass.performed -= instance.OnDecreaseMass;
            @DecreaseMass.canceled -= instance.OnDecreaseMass;
            @DecreaseGravity.started -= instance.OnDecreaseGravity;
            @DecreaseGravity.performed -= instance.OnDecreaseGravity;
            @DecreaseGravity.canceled -= instance.OnDecreaseGravity;
            @DecreaseThrowPower.started -= instance.OnDecreaseThrowPower;
            @DecreaseThrowPower.performed -= instance.OnDecreaseThrowPower;
            @DecreaseThrowPower.canceled -= instance.OnDecreaseThrowPower;
            @DecreaseExplosionForce.started -= instance.OnDecreaseExplosionForce;
            @DecreaseExplosionForce.performed -= instance.OnDecreaseExplosionForce;
            @DecreaseExplosionForce.canceled -= instance.OnDecreaseExplosionForce;
            @DecreaseObjectRadius.started -= instance.OnDecreaseObjectRadius;
            @DecreaseObjectRadius.performed -= instance.OnDecreaseObjectRadius;
            @DecreaseObjectRadius.canceled -= instance.OnDecreaseObjectRadius;
            @IncraseMass.started -= instance.OnIncraseMass;
            @IncraseMass.performed -= instance.OnIncraseMass;
            @IncraseMass.canceled -= instance.OnIncraseMass;
            @IncraseGravity.started -= instance.OnIncraseGravity;
            @IncraseGravity.performed -= instance.OnIncraseGravity;
            @IncraseGravity.canceled -= instance.OnIncraseGravity;
            @IncraseThrowPower.started -= instance.OnIncraseThrowPower;
            @IncraseThrowPower.performed -= instance.OnIncraseThrowPower;
            @IncraseThrowPower.canceled -= instance.OnIncraseThrowPower;
            @IncraseExplosionForce.started -= instance.OnIncraseExplosionForce;
            @IncraseExplosionForce.performed -= instance.OnIncraseExplosionForce;
            @IncraseExplosionForce.canceled -= instance.OnIncraseExplosionForce;
            @IncraseObjectRadius.started -= instance.OnIncraseObjectRadius;
            @IncraseObjectRadius.performed -= instance.OnIncraseObjectRadius;
            @IncraseObjectRadius.canceled -= instance.OnIncraseObjectRadius;
        }

        public void RemoveCallbacks(IParametersActions instance)
        {
            if (m_Wrapper.m_ParametersActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IParametersActions instance)
        {
            foreach (var item in m_Wrapper.m_ParametersActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ParametersActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ParametersActions @Parameters => new ParametersActions(this);
    public interface IParametersActions
    {
        void OnThrowGranade(InputAction.CallbackContext context);
        void OnThrowKnife(InputAction.CallbackContext context);
        void OnDecreaseMass(InputAction.CallbackContext context);
        void OnDecreaseGravity(InputAction.CallbackContext context);
        void OnDecreaseThrowPower(InputAction.CallbackContext context);
        void OnDecreaseExplosionForce(InputAction.CallbackContext context);
        void OnDecreaseObjectRadius(InputAction.CallbackContext context);
        void OnIncraseMass(InputAction.CallbackContext context);
        void OnIncraseGravity(InputAction.CallbackContext context);
        void OnIncraseThrowPower(InputAction.CallbackContext context);
        void OnIncraseExplosionForce(InputAction.CallbackContext context);
        void OnIncraseObjectRadius(InputAction.CallbackContext context);
    }
}
