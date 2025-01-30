using System;
using UnityEngine;

namespace AtomicGame
{
    [Serializable]
    public sealed class AudioClipConfig
    {
        [SerializeField]
        public AudioClip playerJump;
        
        [SerializeField]
        public AudioClip playerDeath;
        
        [SerializeField]
        public AudioClip addScoreCoin;
        
        [SerializeField]
        public AudioClip addScoreKey;
        
        [SerializeField]
        public AudioClip addScorePumpkin;
    }
}