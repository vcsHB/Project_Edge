using System;
using System.Collections.Generic;
using UnityEngine;
namespace Project_Edge.AgentSytstem.PlayerManage.FSM
{

    public class PlayerStateMachine
    {

        private Dictionary<PlayerStateType, PlayerState> _stateDictionary;
        private Player _owner;
        public void Intialize(Player owner)
        {
            _owner = owner;
        }

        public void AddState(PlayerStateType type)
        {
            Type t = Type.GetType($"Agents.Players.FSM.Player{type}State");
            PlayerState state = Activator.CreateInstance(t, _owner, this, 0) as PlayerState;
            _stateDictionary.Add(type, state);
        }
    }
}