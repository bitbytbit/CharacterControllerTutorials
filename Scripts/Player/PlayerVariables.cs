using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public partial class PlayerStateManager
{
    public CharacterController Controller;
    public PlayerInput Input;
    public PlayerBaseState CurrentState;

    public Vector3 MoveVector;
    public Vector2 InputVector;
    public float PlayerSpeed;
    public float PlayerRotateSpeed;
    private Vector3 _gravityVector;


    #region ConcreteStates
    public PlayerWalkState WalkingState = new PlayerWalkState();
    public PlayerIdleState IdleState = new PlayerIdleState();
    public PlayerFallState FallingState = new PlayerFallState();
    public PlayerJumpState JumpState = new PlayerJumpState();
    #endregion

}
