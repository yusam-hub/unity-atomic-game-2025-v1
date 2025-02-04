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
        public AudioClip pumpkinDeath;
        
        [SerializeField]
        public AudioClip pumpkinAttack;
        
        [SerializeField]
        public AudioClip addScoreCoin;
        
        [SerializeField]
        public AudioClip addScoreKey;
        
        [SerializeField]
        public AudioClip addScorePumpkin;
        
        [SerializeField]
        public AudioClip gameWin;
        
        [SerializeField]
        public AudioClip gameOver;
    }
}