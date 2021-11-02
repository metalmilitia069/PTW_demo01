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
                    ""name"": ""positive"",
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
                    ""name"": ""negative"",
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
        },
        {
            ""name"": ""LocomotionBackView"",
            ""id"": ""c81918e8-d560-46be-8aa4-2d7018f1b8ed"",
            ""actions"": [
                {
                    ""name"": ""VerticalMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""67701dbe-15a3-4318-95e8-c027a7998271"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SideMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6949623e-6520-4c34-b011-863110ef1389"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""a2eff13e-2892-4985-9bbd-a0e11f79ed90"",
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
                    ""id"": ""4fa84a08-e876-4485-aed1-1f4b8b4fe5af"",
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
                    ""id"": ""cb8ab873-e484-4ee0-9030-81c46fd8715b"",
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
                    ""id"": ""b737be20-baa9-4b28-a73e-d3e07b072946"",
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
                    ""id"": ""7886924f-5735-4d0b-96ad-b2818f16663b"",
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
                    ""id"": ""bb91baf7-a546-4c60-872f-98956f8e5d55"",
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
                    ""id"": ""cfa1d8fc-bfe9-4813-a37f-96037fedd826"",
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
                    ""id"": ""a3f355ec-6a6e-4945-b281-6cbc86aeae67"",
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
                    ""id"": ""3f071046-adb8-4080-a4a7-63b359f10280"",
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
                    ""id"": ""04fd5ce4-a9a9-4a34-9b8b-eaa7796e3a8c"",
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
                    ""id"": ""80322ff0-47e6-4b35-b7a1-57e04d250f3f"",
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
                    ""id"": ""bad5194d-412a-4c3a-adda-3c81c5c895d9"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SideMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Shooting"",
            ""id"": ""4bb4c204-7f63-4304-ab7a-5283aa0faf17"",
            ""actions"": [
                {
                    ""name"": ""FireButton"",
                    ""type"": ""Value"",
                    ""id"": ""1fbf1a7a-288d-4f9f-b2a2-00eac0cf55b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f13df728-e3ad-4d7f-ad31-5ba5739521db"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0339286d-8ea3-4e51-8543-d9851b550787"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ChangeAmmo"",
            ""id"": ""6ba959bb-7342-4e04-97d0-bece816e59c0"",
            ""actions"": [
                {
                    ""name"": ""AmmoChanger"",
                    ""type"": ""Button"",
                    ""id"": ""7ed12174-578b-4a57-8340-92b722de4acd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""653ae477-fc4b-40b2-8af9-3530ac56dace"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AmmoChanger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""899a2890-355f-4003-8a50-566e743ebea8"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AmmoChanger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""CancelClosePanel"",
            ""id"": ""157e3d6c-ac62-4b8e-bb7b-1ee0d04c6276"",
            ""actions"": [
                {
                    ""name"": ""CancelClose"",
                    ""type"": ""Button"",
                    ""id"": ""7989e417-fe5f-405f-bc1a-56846df41a3d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d119ce2d-04c3-4220-a6d0-74720a9d5e0f"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CancelClose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf426f61-78ac-454b-b13d-dc3d5f464579"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CancelClose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""OpenMenuEscape"",
            ""id"": ""2a9973ff-d4f2-4fb0-94e1-eef51c77ab69"",
            ""actions"": [
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""57c47b21-d0e5-4656-ac89-7066939ce895"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a97c0767-deeb-4ad0-b0ca-0952668e1ab0"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f12b9eed-f4ce-48da-9aae-0b60ecaa7a68"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        // LocomotionBackView
        m_LocomotionBackView = asset.FindActionMap("LocomotionBackView", throwIfNotFound: true);
        m_LocomotionBackView_VerticalMove = m_LocomotionBackView.FindAction("VerticalMove", throwIfNotFound: true);
        m_LocomotionBackView_SideMove = m_LocomotionBackView.FindAction("SideMove", throwIfNotFound: true);
        // Shooting
        m_Shooting = asset.FindActionMap("Shooting", throwIfNotFound: true);
        m_Shooting_FireButton = m_Shooting.FindAction("FireButton", throwIfNotFound: true);
        // ChangeAmmo
        m_ChangeAmmo = asset.FindActionMap("ChangeAmmo", throwIfNotFound: true);
        m_ChangeAmmo_AmmoChanger = m_ChangeAmmo.FindAction("AmmoChanger", throwIfNotFound: true);
        // CancelClosePanel
        m_CancelClosePanel = asset.FindActionMap("CancelClosePanel", throwIfNotFound: true);
        m_CancelClosePanel_CancelClose = m_CancelClosePanel.FindAction("CancelClose", throwIfNotFound: true);
        // OpenMenuEscape
        m_OpenMenuEscape = asset.FindActionMap("OpenMenuEscape", throwIfNotFound: true);
        m_OpenMenuEscape_Escape = m_OpenMenuEscape.FindAction("Escape", throwIfNotFound: true);
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

    // LocomotionBackView
    private readonly InputActionMap m_LocomotionBackView;
    private ILocomotionBackViewActions m_LocomotionBackViewActionsCallbackInterface;
    private readonly InputAction m_LocomotionBackView_VerticalMove;
    private readonly InputAction m_LocomotionBackView_SideMove;
    public struct LocomotionBackViewActions
    {
        private @PlayerControls m_Wrapper;
        public LocomotionBackViewActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @VerticalMove => m_Wrapper.m_LocomotionBackView_VerticalMove;
        public InputAction @SideMove => m_Wrapper.m_LocomotionBackView_SideMove;
        public InputActionMap Get() { return m_Wrapper.m_LocomotionBackView; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LocomotionBackViewActions set) { return set.Get(); }
        public void SetCallbacks(ILocomotionBackViewActions instance)
        {
            if (m_Wrapper.m_LocomotionBackViewActionsCallbackInterface != null)
            {
                @VerticalMove.started -= m_Wrapper.m_LocomotionBackViewActionsCallbackInterface.OnVerticalMove;
                @VerticalMove.performed -= m_Wrapper.m_LocomotionBackViewActionsCallbackInterface.OnVerticalMove;
                @VerticalMove.canceled -= m_Wrapper.m_LocomotionBackViewActionsCallbackInterface.OnVerticalMove;
                @SideMove.started -= m_Wrapper.m_LocomotionBackViewActionsCallbackInterface.OnSideMove;
                @SideMove.performed -= m_Wrapper.m_LocomotionBackViewActionsCallbackInterface.OnSideMove;
                @SideMove.canceled -= m_Wrapper.m_LocomotionBackViewActionsCallbackInterface.OnSideMove;
            }
            m_Wrapper.m_LocomotionBackViewActionsCallbackInterface = instance;
            if (instance != null)
            {
                @VerticalMove.started += instance.OnVerticalMove;
                @VerticalMove.performed += instance.OnVerticalMove;
                @VerticalMove.canceled += instance.OnVerticalMove;
                @SideMove.started += instance.OnSideMove;
                @SideMove.performed += instance.OnSideMove;
                @SideMove.canceled += instance.OnSideMove;
            }
        }
    }
    public LocomotionBackViewActions @LocomotionBackView => new LocomotionBackViewActions(this);

    // Shooting
    private readonly InputActionMap m_Shooting;
    private IShootingActions m_ShootingActionsCallbackInterface;
    private readonly InputAction m_Shooting_FireButton;
    public struct ShootingActions
    {
        private @PlayerControls m_Wrapper;
        public ShootingActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @FireButton => m_Wrapper.m_Shooting_FireButton;
        public InputActionMap Get() { return m_Wrapper.m_Shooting; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShootingActions set) { return set.Get(); }
        public void SetCallbacks(IShootingActions instance)
        {
            if (m_Wrapper.m_ShootingActionsCallbackInterface != null)
            {
                @FireButton.started -= m_Wrapper.m_ShootingActionsCallbackInterface.OnFireButton;
                @FireButton.performed -= m_Wrapper.m_ShootingActionsCallbackInterface.OnFireButton;
                @FireButton.canceled -= m_Wrapper.m_ShootingActionsCallbackInterface.OnFireButton;
            }
            m_Wrapper.m_ShootingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FireButton.started += instance.OnFireButton;
                @FireButton.performed += instance.OnFireButton;
                @FireButton.canceled += instance.OnFireButton;
            }
        }
    }
    public ShootingActions @Shooting => new ShootingActions(this);

    // ChangeAmmo
    private readonly InputActionMap m_ChangeAmmo;
    private IChangeAmmoActions m_ChangeAmmoActionsCallbackInterface;
    private readonly InputAction m_ChangeAmmo_AmmoChanger;
    public struct ChangeAmmoActions
    {
        private @PlayerControls m_Wrapper;
        public ChangeAmmoActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @AmmoChanger => m_Wrapper.m_ChangeAmmo_AmmoChanger;
        public InputActionMap Get() { return m_Wrapper.m_ChangeAmmo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ChangeAmmoActions set) { return set.Get(); }
        public void SetCallbacks(IChangeAmmoActions instance)
        {
            if (m_Wrapper.m_ChangeAmmoActionsCallbackInterface != null)
            {
                @AmmoChanger.started -= m_Wrapper.m_ChangeAmmoActionsCallbackInterface.OnAmmoChanger;
                @AmmoChanger.performed -= m_Wrapper.m_ChangeAmmoActionsCallbackInterface.OnAmmoChanger;
                @AmmoChanger.canceled -= m_Wrapper.m_ChangeAmmoActionsCallbackInterface.OnAmmoChanger;
            }
            m_Wrapper.m_ChangeAmmoActionsCallbackInterface = instance;
            if (instance != null)
            {
                @AmmoChanger.started += instance.OnAmmoChanger;
                @AmmoChanger.performed += instance.OnAmmoChanger;
                @AmmoChanger.canceled += instance.OnAmmoChanger;
            }
        }
    }
    public ChangeAmmoActions @ChangeAmmo => new ChangeAmmoActions(this);

    // CancelClosePanel
    private readonly InputActionMap m_CancelClosePanel;
    private ICancelClosePanelActions m_CancelClosePanelActionsCallbackInterface;
    private readonly InputAction m_CancelClosePanel_CancelClose;
    public struct CancelClosePanelActions
    {
        private @PlayerControls m_Wrapper;
        public CancelClosePanelActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CancelClose => m_Wrapper.m_CancelClosePanel_CancelClose;
        public InputActionMap Get() { return m_Wrapper.m_CancelClosePanel; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CancelClosePanelActions set) { return set.Get(); }
        public void SetCallbacks(ICancelClosePanelActions instance)
        {
            if (m_Wrapper.m_CancelClosePanelActionsCallbackInterface != null)
            {
                @CancelClose.started -= m_Wrapper.m_CancelClosePanelActionsCallbackInterface.OnCancelClose;
                @CancelClose.performed -= m_Wrapper.m_CancelClosePanelActionsCallbackInterface.OnCancelClose;
                @CancelClose.canceled -= m_Wrapper.m_CancelClosePanelActionsCallbackInterface.OnCancelClose;
            }
            m_Wrapper.m_CancelClosePanelActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CancelClose.started += instance.OnCancelClose;
                @CancelClose.performed += instance.OnCancelClose;
                @CancelClose.canceled += instance.OnCancelClose;
            }
        }
    }
    public CancelClosePanelActions @CancelClosePanel => new CancelClosePanelActions(this);

    // OpenMenuEscape
    private readonly InputActionMap m_OpenMenuEscape;
    private IOpenMenuEscapeActions m_OpenMenuEscapeActionsCallbackInterface;
    private readonly InputAction m_OpenMenuEscape_Escape;
    public struct OpenMenuEscapeActions
    {
        private @PlayerControls m_Wrapper;
        public OpenMenuEscapeActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Escape => m_Wrapper.m_OpenMenuEscape_Escape;
        public InputActionMap Get() { return m_Wrapper.m_OpenMenuEscape; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OpenMenuEscapeActions set) { return set.Get(); }
        public void SetCallbacks(IOpenMenuEscapeActions instance)
        {
            if (m_Wrapper.m_OpenMenuEscapeActionsCallbackInterface != null)
            {
                @Escape.started -= m_Wrapper.m_OpenMenuEscapeActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_OpenMenuEscapeActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_OpenMenuEscapeActionsCallbackInterface.OnEscape;
            }
            m_Wrapper.m_OpenMenuEscapeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
            }
        }
    }
    public OpenMenuEscapeActions @OpenMenuEscape => new OpenMenuEscapeActions(this);
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
    public interface ILocomotionBackViewActions
    {
        void OnVerticalMove(InputAction.CallbackContext context);
        void OnSideMove(InputAction.CallbackContext context);
    }
    public interface IShootingActions
    {
        void OnFireButton(InputAction.CallbackContext context);
    }
    public interface IChangeAmmoActions
    {
        void OnAmmoChanger(InputAction.CallbackContext context);
    }
    public interface ICancelClosePanelActions
    {
        void OnCancelClose(InputAction.CallbackContext context);
    }
    public interface IOpenMenuEscapeActions
    {
        void OnEscape(InputAction.CallbackContext context);
    }
}
