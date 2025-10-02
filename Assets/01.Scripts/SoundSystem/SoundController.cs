using System.Collections.Generic;
using UnityEngine;
namespace MINISoundManage
{

    public class SoundController : MonoSingleton<SoundController>
    {
        [SerializeField] private int _defaultPoolAmount;
        [SerializeField] private SoundPool _pool;


        private void Start()
        {
            _pool.Initialize(_defaultPoolAmount);
        }

        private void OnDestroy()
        {
            
            _pool.Clear();
        }


        public SoundPlayer PlaySound(SoundSO soundSO, Vector2 position)
        {
            SoundPlayer player = _pool.GetSoundPlayer(position);
            player.PlaySound(soundSO);
            return player;
        }

        


    }
}