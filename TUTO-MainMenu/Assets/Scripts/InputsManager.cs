using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputsManager : MonoBehaviour
{
    private PlayerInput inputs;

    private void Awake()
    {
        inputs = GetComponent<PlayerInput>();
    }
}