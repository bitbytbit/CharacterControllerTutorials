

using UnityEngine;

public class PlayerJumpState : PlayerBaseState
{
    private float force = .1f;
    private int maxForce = 5;

    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("ENTERED JUMP STATE");
    }
    public override void ExitState(PlayerStateManager player)
    {
        Debug.Log("EXITING JUMP STATE");
        player.MoveVector.y = 0;
    }
    public override void UpdateState(PlayerStateManager player)
    {
        player.MoveVector.y += force;

        if (player.MoveVector.y >= maxForce)
        {
            player.SwitchState(player.FallingState);
        }

        player.Move();
    }
}
