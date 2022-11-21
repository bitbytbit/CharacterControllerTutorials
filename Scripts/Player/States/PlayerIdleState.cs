

using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("ENTERED IDLE STATE");
    }
    public override void ExitState(PlayerStateManager player)
    {
        Debug.Log("EXITING IDLE STATE");
    }
    public override void UpdateState(PlayerStateManager player)
    {
        if (player.MoveVector.magnitude != 0)
        {
            player.SwitchState(player.WalkingState);
        }
    }
}
