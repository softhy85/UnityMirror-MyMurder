//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.0
//     from Assets/Scripts/Player/Controller/Escapist/EscapistController.inputactions
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

public partial class @EscapistController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @EscapistController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""EscapistController"",
    ""maps"": [
        {
            ""name"": ""Escapist"",
            ""id"": ""94a90755-6b3b-446e-8b4d-02fb1cd2260b"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""61557d66-76b4-4894-873a-b39a6bbf5680"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""06a497d8-ea81-4442-b56e-3b7a8405ae8d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9e8b5563-e456-4e4c-9dc9-a9e497ad1cab"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""4e1a902a-ac26-4c6e-abce-4988cf5e14f2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Down"",
                    ""id"": ""7893659e-2280-4b01-a1ed-384c5b5e0769"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""87ca97c4-9eeb-4c79-a274-db82dbf3e419"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""37eb7191-3372-4482-8343-958d079845e9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a7496e6f-1e01-4400-b309-2561d24d97a1"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Escapist
        m_Escapist = asset.FindActionMap("Escapist", throwIfNotFound: true);
        m_Escapist_Movement = m_Escapist.FindAction("Movement", throwIfNotFound: true);
        m_Escapist_Interaction = m_Escapist.FindAction("Interaction", throwIfNotFound: true);
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

    // Escapist
    private readonly InputActionMap m_Escapist;
    private List<IEscapistActions> m_EscapistActionsCallbackInterfaces = new List<IEscapistActions>();
    private readonly InputAction m_Escapist_Movement;
    private readonly InputAction m_Escapist_Interaction;
    public struct EscapistActions
    {
        private @EscapistController m_Wrapper;
        public EscapistActions(@EscapistController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Escapist_Movement;
        public InputAction @Interaction => m_Wrapper.m_Escapist_Interaction;
        public InputActionMap Get() { return m_Wrapper.m_Escapist; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EscapistActions set) { return set.Get(); }
        public void AddCallbacks(IEscapistActions instance)
        {
            if (instance == null || m_Wrapper.m_EscapistActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_EscapistActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Interaction.started += instance.OnInteraction;
            @Interaction.performed += instance.OnInteraction;
            @Interaction.canceled += instance.OnInteraction;
        }

        private void UnregisterCallbacks(IEscapistActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Interaction.started -= instance.OnInteraction;
            @Interaction.performed -= instance.OnInteraction;
            @Interaction.canceled -= instance.OnInteraction;
        }

        public void RemoveCallbacks(IEscapistActions instance)
        {
            if (m_Wrapper.m_EscapistActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IEscapistActions instance)
        {
            foreach (var item in m_Wrapper.m_EscapistActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_EscapistActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public EscapistActions @Escapist => new EscapistActions(this);
    public interface IEscapistActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
    }
}