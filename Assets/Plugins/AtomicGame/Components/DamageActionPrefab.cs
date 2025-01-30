using System;
using UnityEngine;

namespace AtomicGame
{
    public class DamageActionPrefab : MonoBehaviour
    {
        [SerializeField]
        private AudioSource _audioSource;

        [SerializeField]
        private ParticleSystem _particleSystem;
        private void OnEnable()
        {
            _audioSource.Stop();
            _audioSource.Play();
            
            _particleSystem.Stop();
            _particleSystem.Play();
        }
    }
}