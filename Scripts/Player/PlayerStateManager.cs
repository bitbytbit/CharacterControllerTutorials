using UnityEngine;
using UnityEngine.InputSystem;

public partial class PlayerStateManager : MonoBehaviour
{
    private void Awake()
    {
        Controller = GetComponent<CharacterController>();
        Input = GetComponent<PlayerInput>();
        PlayerSpeed = 10f;
        PlayerRotateSpeed = 100;

        _gravityVector = new Vector3(0, -9.81f, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        CurrentState = IdleState;
        CurrentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentState != JumpState
            && CurrentState != FallingState
            && !Controller.isGrounded
        )
        {
            SwitchState(FallingState);
        }

        CurrentState.UpdateState(this);
        ApplyGravity();
    }

    public void SwitchState(PlayerBaseState state)
    {
        CurrentState.ExitState(this);
        CurrentState = state;
        state.EnterState(this);
    }

    #region Movement

    public void Move()
    {
        Controller.Move(PlayerSpeed * MoveVector * Time.deltaTime);
        RotateTowardsVector();
    }

    public void ApplyGravity()
    {
        Controller.Move(_gravityVector * Time.deltaTime);
    }

    public void RotateTowardsVector()
    {
        var xzDirection = new Vector3(MoveVector.x, 0, MoveVector.z);
        if (xzDirection.magnitude == 0) return;

        var rotation = Quaternion.LookRotation(xzDirection);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, PlayerRotateSpeed);
    }
    #endregion
}
