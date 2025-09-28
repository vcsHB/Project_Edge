using UnityEngine;
namespace Project_Edge.AgentSytstem.PlayerManage.FSM
{

    public class PlayerState
    {

        protected Player _player;
        protected PlayerStateMachine _stateMachine;
        protected PlayerMover _mover;
        
        protected Animator _animator;
        protected int _animationHash;


        public PlayerState(Player player, PlayerStateMachine stateMachine, int animationHash)
        {
            _player = player;
            _stateMachine = stateMachine;
            _mover = player.GetCompo<PlayerMover>();
            _animationHash = animationHash;
        }

        public virtual void Enter()
        {

        }

        public virtual void UpdateState()
        {

        }

        public virtual void Exit()
        {

        }
    }
}