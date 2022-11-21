
using UnityEngine;

public class PlayerFallState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("ENTERED FALL STATE");
    }
    public override void ExitState(PlayerStateManager player)
    {
        Debug.Log("EXITED FALL STATE");
    }
    public override void UpdateState(PlayerStateManager player)
    {
        if (player.Controller.isGrounded)
        {
            player.SwitchState(player.IdleState);
        }
        else
        {
            player.Move();
        }
    }
}
