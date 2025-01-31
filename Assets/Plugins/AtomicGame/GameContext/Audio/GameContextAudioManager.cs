using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

namespace AtomicGame
{
    public sealed class GameContextAudioManager : MonoBehaviour
    {
        [SerializeField]
        public AudioMixer mainMixer;
        
        [SerializeField]
        public AudioSource musicSource;
        
        [SerializeField]
        public AudioSource effectSource; 
        
        public static GameContextAudioManager Instance { get; private set; }
        
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
        }

        public static void PlayOneShot(AudioClip clip)
        {
            Instance.effectSource.PlayOneShot(clip);
        }
    }
}