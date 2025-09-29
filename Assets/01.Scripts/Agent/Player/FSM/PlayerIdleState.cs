using UnityEngine;
namespace Project_Edge.AgentSytstem.PlayerManage.FSM
{

    public class PlayerIdleState : PlayerState
    {
        public PlayerIdleState(Player player, PlayerStateMachine stateMachine, int animationHash) : base(player, stateMachine, animationHash)
        {
        }
    }
}