using System;
using UnityEngine;

namespace AtomicGame
{
    public class CursorLock : MonoBehaviour
    {
        [SerializeField] private bool _isLock = true;
        private void Awake()
        {
            if (_isLock)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;              
            }
        }
    }
}