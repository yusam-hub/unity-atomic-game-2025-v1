using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Game.Scripts.GameContext.Audio
{
    [RequireComponent(typeof(AudioSource))]
    public class  AudioManager : MonoBehaviour
    {
       
        private AudioSource _audioSource;
        
        private static AudioManager _instance = null;
        
        private void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
            }
            _audioSource = GetComponent<AudioSource>();
        }

        public static void PlayOneShot(AudioClip clip)
        {
            _instance._audioSource.PlayOneShot(clip);
        }
    }
}