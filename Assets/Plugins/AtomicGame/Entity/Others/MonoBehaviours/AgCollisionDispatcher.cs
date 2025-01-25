using System;
using UnityEngine;

namespace AtomicGame
{
    public sealed class AgCollisionDispatcher : MonoBehaviour
    {
        [SerializeField] private bool _isDebugging; 
        public event Action<Collision> OnEnter;
        public event Action<Collision> OnStay;
        public event Action<Collision> OnExit;
        
        private void OnCollisionEnter(Collision other)
        {
            if (_isDebugging)
            {
                Debug.Log($"OnCollisionEnter {other.gameObject.name}");
                //float angle = Vector3.Angle(other.contacts[0].thisCollider.transform.up, other.contacts[0].normal);
                //Debug.Log($"OnCollisionEnter {other.contacts[0].thisCollider.gameObject.name} -> {other.contacts[0].otherCollider.gameObject.name} with angle = {angle}, point = {other.contacts[0].point}, impulse = {other.contacts[0].impulse}");
            }
            this.OnEnter?.Invoke(other);
        }

        private void OnCollisionStay(Collision other)
        {
            if (_isDebugging)
            {
                Debug.Log($"OnCollisionStay {other.gameObject.name}");
                //Debug.DrawRay(other.contacts[0].point, other.contacts[0].normal, Color.yellow);
            }
            this.OnStay?.Invoke(other);
        }

        private void OnCollisionExit(Collision other)
        {
            if (_isDebugging)
            {
                Debug.Log($"OnCollisionExit {other.gameObject.name}");
            }
            this.OnExit?.Invoke(other);
        }
    }
}