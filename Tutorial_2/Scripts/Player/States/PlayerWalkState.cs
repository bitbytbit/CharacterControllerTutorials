

using UnityEngine;

public class PlayerWalkState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("ENTERED WALK STATE");
    }
    public override void ExitState(PlayerStateManager player)
    {
        Debug.Log("EXITING WALK STATE");
    }
    public override void UpdateState(PlayerStateManager player)
    {
        if (player.MoveVector.magnitude == 0)
        {
            player.SwitchState(player.IdleState);
        }
        else
        {
            player.Move();
        }
    }
}
