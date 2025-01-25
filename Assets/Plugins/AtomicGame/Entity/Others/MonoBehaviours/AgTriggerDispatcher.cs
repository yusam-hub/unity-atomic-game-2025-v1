using System;
using UnityEngine;

namespace AtomicGame
{
    public sealed class AgTriggerDispatcher : MonoBehaviour
    {
        [SerializeField] private bool isDebugging = false; 
        public event Action<Collider> OnEnter;
        public event Action<Collider> OnStay;
        public event Action<Collider> OnExit;
        private void OnTriggerEnter(Collider other)
        {
            if (isDebugging)
            {
                Debug.Log($"OnTriggerEnter {other.gameObject.name}");
            }
            this.OnEnter?.Invoke(other);
        }

        private void OnTriggerStay(Collider other)
        {
            if (isDebugging)
            {
                Debug.Log($"OnTriggerStay {other.gameObject.name}");
            }
            this.OnStay?.Invoke(other);
        }

        private void OnTriggerExit(Collider other)
        {
            if (isDebugging)
            {
                Debug.Log($"OnTriggerExit {other.gameObject.name}");
            }
            this.OnExit?.Invoke(other);
        }
    }
}