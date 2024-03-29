//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.0
//     from Assets/Scripts/Player/Controller/Monster/MonsterController.inputactions
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

public partial class @MonsterController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MonsterController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MonsterController"",
    ""maps"": [
        {
            ""name"": ""Monster"",
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
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""d4cc34c6-7133-412c-9c2d-570513c9da02"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack 0"",
                    ""type"": ""Button"",
                    ""id"": ""dc5c8234-7757-4d2b-84c3-38aafe3100c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack 1"",
                    ""type"": ""Button"",
                    ""id"": ""ebe9294b-0888-4936-aa61-98939ba15893"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack 2"",
                    ""type"": ""Button"",
                    ""id"": ""b674c054-922c-4903-bd7b-550cf60e1f93"",
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
                    ""id"": ""11126db0-ac40-42e4-8599-4a2566108c4b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack 0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d68eb9ad-9eb0-409a-bf3e-0f7706e17c66"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f16eaf44-fcf9-44cd-ae16-6fdbe9291cbe"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""378132d5-7ff8-49fc-bb06-5a7e8b9b0311"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Monster
        m_Monster = asset.FindActionMap("Monster", throwIfNotFound: true);
        m_Monster_Movement = m_Monster.FindAction("Movement", throwIfNotFound: true);
        m_Monster_Sprint = m_Monster.FindAction("Sprint", throwIfNotFound: true);
        m_Monster_Attack0 = m_Monster.FindAction("Attack 0", throwIfNotFound: true);
        m_Monster_Attack1 = m_Monster.FindAction("Attack 1", throwIfNotFound: true);
        m_Monster_Attack2 = m_Monster.FindAction("Attack 2", throwIfNotFound: true);
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

    // Monster
    private readonly InputActionMap m_Monster;
    private List<IMonsterActions> m_MonsterActionsCallbackInterfaces = new List<IMonsterActions>();
    private readonly InputAction m_Monster_Movement;
    private readonly InputAction m_Monster_Sprint;
    private readonly InputAction m_Monster_Attack0;
    private readonly InputAction m_Monster_Attack1;
    private readonly InputAction m_Monster_Attack2;
    public struct MonsterActions
    {
        private @MonsterController m_Wrapper;
        public MonsterActions(@MonsterController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Monster_Movement;
        public InputAction @Sprint => m_Wrapper.m_Monster_Sprint;
        public InputAction @Attack0 => m_Wrapper.m_Monster_Attack0;
        public InputAction @Attack1 => m_Wrapper.m_Monster_Attack1;
        public InputAction @Attack2 => m_Wrapper.m_Monster_Attack2;
        public InputActionMap Get() { return m_Wrapper.m_Monster; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MonsterActions set) { return set.Get(); }
        public void AddCallbacks(IMonsterActions instance)
        {
            if (instance == null || m_Wrapper.m_MonsterActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MonsterActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Attack0.started += instance.OnAttack0;
            @Attack0.performed += instance.OnAttack0;
            @Attack0.canceled += instance.OnAttack0;
            @Attack1.started += instance.OnAttack1;
            @Attack1.performed += instance.OnAttack1;
            @Attack1.canceled += instance.OnAttack1;
            @Attack2.started += instance.OnAttack2;
            @Attack2.performed += instance.OnAttack2;
            @Attack2.canceled += instance.OnAttack2;
        }

        private void UnregisterCallbacks(IMonsterActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Attack0.started -= instance.OnAttack0;
            @Attack0.performed -= instance.OnAttack0;
            @Attack0.canceled -= instance.OnAttack0;
            @Attack1.started -= instance.OnAttack1;
            @Attack1.performed -= instance.OnAttack1;
            @Attack1.canceled -= instance.OnAttack1;
            @Attack2.started -= instance.OnAttack2;
            @Attack2.performed -= instance.OnAttack2;
            @Attack2.canceled -= instance.OnAttack2;
        }

        public void RemoveCallbacks(IMonsterActions instance)
        {
            if (m_Wrapper.m_MonsterActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMonsterActions instance)
        {
            foreach (var item in m_Wrapper.m_MonsterActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MonsterActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MonsterActions @Monster => new MonsterActions(this);
    public interface IMonsterActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnAttack0(InputAction.CallbackContext context);
        void OnAttack1(InputAction.CallbackContext context);
        void OnAttack2(InputAction.CallbackContext context);
    }
}
