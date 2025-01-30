using System;
using UnityEngine;

namespace AtomicGame
{
    public sealed class TriggerDispatcher : MonoBehaviour
    {
        [SerializeField] private bool isDebuggingEnter = false; 
        [SerializeField] private bool isDebuggingStay = false;
        [SerializeField] private bool isDebuggingExit = false;
        public event Action<Collider> OnEnter;
        public event Action<Collider> OnStay;
        public event Action<Collider> OnExit;
        private void OnTriggerEnter(Collider other)
        {
            if (isDebuggingEnter)
            {
                Debug.Log($"OnTriggerEnter {other.gameObject.name}");
            }
            this.OnEnter?.Invoke(other);
        }

        private void OnTriggerStay(Collider other)
        {
            if (isDebuggingStay)
            {
                Debug.Log($"OnTriggerStay {other.gameObject.name}");
            }
            this.OnStay?.Invoke(other);
        }

        private void OnTriggerExit(Collider other)
        {
            if (isDebuggingExit)
            {
                Debug.Log($"OnTriggerExit {other.gameObject.name}");
            }
            this.OnExit?.Invoke(other);
        }
    }
}