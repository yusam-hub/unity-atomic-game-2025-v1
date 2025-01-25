using System;
using UnityEngine;

namespace AtomicGame.Common
{
    public sealed class AgControllerColliderHitDispatcher : MonoBehaviour
    {
        [SerializeField] private bool _isDebugging; 
        public event Action<ControllerColliderHit> OnHit;
        
        private void OnControllerColliderHit(ControllerColliderHit hit)
        {
            if (_isDebugging)
            {
                Debug.Log($"OnControllerColliderHit {hit.gameObject.name}");
            }
            this.OnHit?.Invoke(hit);
        }
    }
}