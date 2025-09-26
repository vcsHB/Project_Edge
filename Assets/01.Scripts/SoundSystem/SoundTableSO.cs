﻿using System.Collections.Generic;
using UnityEngine;

namespace SoundManage
{
    [CreateAssetMenu(menuName = "SO/SoundTableSO")]
    public class SoundTableSO : ScriptableObject
    {
        public AudioType audioType;
        public List<SoundSO> soundSOList = new();


#if UNITY_EDITOR
        private void OnValidate()
        {
            Debug.Log("Detected Change");
            for (int i = 0; i < soundSOList.Count; i++)
            {
                SoundSO sound = soundSOList[i];
                if (sound != null)
                {
                    sound.SetAudioType(audioType);
                    UnityEditor.EditorUtility.SetDirty(sound);
                }
            }
        }
#endif

    }
}