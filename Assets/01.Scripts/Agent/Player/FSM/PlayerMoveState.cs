using UnityEngine;
namespace Project_Edge.AgentSytstem.PlayerManage.FSM
{

    public class PlayerMoveState : PlayerState
    {
        public PlayerMoveState(Player player, PlayerStateMachine stateMachine, int animationHash) : base(player, stateMachine, animationHash)
        {
        }
    }
}