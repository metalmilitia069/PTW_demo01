// GENERATED AUTOMATICALLY FROM 'Assets/_Final Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""LocomotionTopView"",
            ""id"": ""df12c6cb-f8f5-4c92-9f33-82a5bd36b704"",
            ""actions"": [
                {
                    ""name"": ""SideMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""71633047-4dbd-4303-8b74-ee5368f58398"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ForwardMove"",
                    ""type"": ""Button"",
                    ""id"": ""9ad8dcb7-3fc6-4610-acde-3428da567e60"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""9958975b-6d8d-4e03-881d-6d8b8398246a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": """",
                    ""action"": ""SideMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""95e4d5bd-5f84-48d6-a214-03dfd216b745"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""10844c9f-5647-40b5-98b9-6d35ef71b222"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""73be3a04-e1df-40de-9de8-82d609acac1f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d27158e5-a81c-488b-98a8-cfec6b736369"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0a8d6ccf-b8f0-45ce-a106-f38d7e4ec05b"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""d4b93b4a-7884-4d14-8e07-690fba6b608f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ffbb41be-5276-4b5f-9c5e-9f212887f686"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""dfd910e0-afa2-4f8d-b5bf-df322568ec36"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""7c37e248-cd64-40c9-804b-2fe4b98d1f2d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7645212a-ed73-4113-b30a-5ab6c4e1f4e6"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""be21ff68-6a28-4619-bc6f-0d5129bfd4c0"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""LocomotionSideView"",
            ""id"": ""870c0d2d-2159-4c29-9a7e-3c64e1199db5"",
            ""actions"": [
                {
                    ""name"": ""VerticalMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""35291e57-cec3-444e-9af9-139589bb1ed2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ForwardMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bb81c25f-cb2e-4b44-8e4f-f21c3ac3211a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""d4183e39-35e3-4841-9bbe-475a8abe3ee4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c070438c-0e1f-4ce0-bc91-8153d8c99c04"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""47393df4-8ebb-4e63-8896-1608ad2f8946"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Xbox"",
                    ""id"": ""86a716e6-91cc-470d-bd23-c7afa19ccdb8"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""17e8c969-eb59-4bdd-8ec7-3f3261c43275"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""107e34ee-34fa-49f0-aa6f-b18f88c47e68"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VerticalMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""78a764b7-1ec6-417c-a9f9-91f6a9fb6c28"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""55c50324-d8c1-407c-a6ad-c6daa1b909d2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e57471f3-6bd4-4f36-b19e-abbdf346deb7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Xbox"",
                    ""id"": ""fcef9b08-b10e-4606-bd1f-3ce9bd110bce"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3432fb5f-1b32-4958-85c8-f02d9fb89e97"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0d04d3d5-dcd7-42b0-a551-330c50ec356b"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // LocomotionTopView
        m_LocomotionTopView = asset.FindActionMap("LocomotionTopView", throwIfNotFound: true);
        m_LocomotionTopView_SideMove = m_LocomotionTopView.FindAction("SideMove", throwIfNotFound: true);
        m_LocomotionTopView_ForwardMove = m_LocomotionTopView.FindAction("ForwardMove", throwIfNotFound: true);
        // LocomotionSideView
        m_LocomotionSideView = asset.FindActionMap("LocomotionSideView", throwIfNotFound: true);
        m_LocomotionSideView_VerticalMove = m_LocomotionSideView.FindAction("VerticalMove", throwIfNotFound: true);
        m_LocomotionSideView_ForwardMove = m_LocomotionSideView.FindAction("ForwardMove", throwIfNotFound: true);
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

    // LocomotionTopView
    private readonly InputActionMap m_LocomotionTopView;
    private ILocomotionTopViewActions m_LocomotionTopViewActionsCallbackInterface;
    private readonly InputAction m_LocomotionTopView_SideMove;
    private readonly InputAction m_LocomotionTopView_ForwardMove;
    public struct LocomotionTopViewActions
    {
        private @PlayerControls m_Wrapper;
        public LocomotionTopViewActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SideMove => m_Wrapper.m_LocomotionTopView_SideMove;
        public InputAction @ForwardMove => m_Wrapper.m_LocomotionTopView_ForwardMove;
        public InputActionMap Get() { return m_Wrapper.m_LocomotionTopView; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LocomotionTopViewActions set) { return set.Get(); }
        public void SetCallbacks(ILocomotionTopViewActions instance)
        {
            if (m_Wrapper.m_LocomotionTopViewActionsCallbackInterface != null)
            {
                @SideMove.started -= m_Wrapper.m_LocomotionTopViewActionsCallbackInterface.OnSideMove;
                @SideMove.performed -= m_Wrapper.m_LocomotionTopViewActionsCallbackInterface.OnSideMove;
                @SideMove.canceled -= m_Wrapper.m_LocomotionTopViewActionsCallbackInterface.OnSideMove;
                @ForwardMove.started -= m_Wrapper.m_LocomotionTopViewActionsCallbackInterface.OnForwardMove;
                @ForwardMove.performed -= m_Wrapper.m_LocomotionTopViewActionsCallbackInterface.OnForwardMove;
                @ForwardMove.canceled -= m_Wrapper.m_LocomotionTopViewActionsCallbackInterface.OnForwardMove;
            }
            m_Wrapper.m_LocomotionTopViewActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SideMove.started += instance.OnSideMove;
                @SideMove.performed += instance.OnSideMove;
                @SideMove.canceled += instance.OnSideMove;
                @ForwardMove.started += instance.OnForwardMove;
                @ForwardMove.performed += instance.OnForwardMove;
                @ForwardMove.canceled += instance.OnForwardMove;
            }
        }
    }
    public LocomotionTopViewActions @LocomotionTopView => new LocomotionTopViewActions(this);

    // LocomotionSideView
    private readonly InputActionMap m_LocomotionSideView;
    private ILocomotionSideViewActions m_LocomotionSideViewActionsCallbackInterface;
    private readonly InputAction m_LocomotionSideView_VerticalMove;
    private readonly InputAction m_LocomotionSideView_ForwardMove;
    public struct LocomotionSideViewActions
    {
        private @PlayerControls m_Wrapper;
        public LocomotionSideViewActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @VerticalMove => m_Wrapper.m_LocomotionSideView_VerticalMove;
        public InputAction @ForwardMove => m_Wrapper.m_LocomotionSideView_ForwardMove;
        public InputActionMap Get() { return m_Wrapper.m_LocomotionSideView; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LocomotionSideViewActions set) { return set.Get(); }
        public void SetCallbacks(ILocomotionSideViewActions instance)
        {
            if (m_Wrapper.m_LocomotionSideViewActionsCallbackInterface != null)
            {
                @VerticalMove.started -= m_Wrapper.m_LocomotionSideViewActionsCallbackInterface.OnVerticalMove;
                @VerticalMove.performed -= m_Wrapper.m_LocomotionSideViewActionsCallbackInterface.OnVerticalMove;
                @VerticalMove.canceled -= m_Wrapper.m_LocomotionSideViewActionsCallbackInterface.OnVerticalMove;
                @ForwardMove.started -= m_Wrapper.m_LocomotionSideViewActionsCallbackInterface.OnForwardMove;
                @ForwardMove.performed -= m_Wrapper.m_LocomotionSideViewActionsCallbackInterface.OnForwardMove;
                @ForwardMove.canceled -= m_Wrapper.m_LocomotionSideViewActionsCallbackInterface.OnForwardMove;
            }
            m_Wrapper.m_LocomotionSideViewActionsCallbackInterface = instance;
            if (instance != null)
            {
                @VerticalMove.started += instance.OnVerticalMove;
                @VerticalMove.performed += instance.OnVerticalMove;
                @VerticalMove.canceled += instance.OnVerticalMove;
                @ForwardMove.started += instance.OnForwardMove;
                @ForwardMove.performed += instance.OnForwardMove;
                @ForwardMove.canceled += instance.OnForwardMove;
            }
        }
    }
    public LocomotionSideViewActions @LocomotionSideView => new LocomotionSideViewActions(this);
    public interface ILocomotionTopViewActions
    {
        void OnSideMove(InputAction.CallbackContext context);
        void OnForwardMove(InputAction.CallbackContext context);
    }
    public interface ILocomotionSideViewActions
    {
        void OnVerticalMove(InputAction.CallbackContext context);
        void OnForwardMove(InputAction.CallbackContext context);
    }
}
