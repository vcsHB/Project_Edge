using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace MINISoundManage
{
    public class BGMController : MonoBehaviour
    {
        [Header("BGM Setting")]
        [SerializeField] private float _fadeLength = 1f;
        [SerializeField] private int _bgmIndex = -1;
        [SerializeField] private int _playerIndex = 0;
        [SerializeField] private List<SoundSO> _playSequence;
        private AudioSource[] _audioPlayers;

        private AudioSource _currentAudioSource;

        private void Awake()
        {
            _audioPlayers = GetComponentsInChildren<AudioSource>();

        }

        private void Start()
        {
            PlayNextAudio();
        }

        private void Update()
        {
            ChangeBGM();
        }

        public void SetBGMs(List<SoundSO> list)
        {
            _playSequence = list;

        }

        public void ChangeBGM()
        {
            float remainingTime = _currentAudioSource.clip.length - _currentAudioSource.time; // 재생까지 남은 시간
            if (remainingTime < _fadeLength)
            {
                EndAudio();
                PlayNextAudio();
            }
        }

        public void PlayNextAudio()
        {
            _bgmIndex = (_bgmIndex + 1) % _playSequence.Count;
            _playerIndex = (_playerIndex + 1) % _audioPlayers.Length;

            _currentAudioSource = _audioPlayers[_playerIndex];
            _currentAudioSource.clip = _playSequence[_bgmIndex].clip;
            _currentAudioSource.Play();
            _currentAudioSource.DOFade(1f, _fadeLength);
        }

        public void EndAudio()
        {
            _currentAudioSource.DOFade(0f, _fadeLength);

        }



    }
}
