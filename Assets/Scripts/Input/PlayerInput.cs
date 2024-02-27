using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    InputControl control;

    Vector2 axis => control.PlayerInput.PlayerInput.ReadValue<Vector2>();

    public bool Move => axis.x != 0f || axis.y != 0f;

    public float xInput => axis.y != 0 ? 0 : axis.x;
    public float yInput => axis.x != 0 ? 0 : axis.y;
    private void Awake()
    {
        control = new InputControl();
    }
    public void EnableGameplayInputs()
    {
        control.PlayerInput.Enable();
        Cursor.lockState = CursorLockMode.Locked;
    }
}
