using UnityEngine;
using UnityEngine.InputSystem;

public partial class PlayerStateManager
{
    private void OnMovement(InputValue value)
    {
        InputVector = value.Get<Vector2>();
        MoveVector.x = InputVector.x;
        MoveVector.z = InputVector.y;
    }

    private void OnJump(InputValue value)
    {
        if (CurrentState != JumpState && CurrentState != FallingState)
        {
            SwitchState(JumpState);
        }
    }
}