using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public class EntityTransformsInstaller: MonoBehaviour
    {
        [SerializeField]
        private SceneEntity _entity;

        [SerializeField]
        private Transform[] _transforms;

        [SerializeField]
        private bool _installEntityOnAwake = true;

        private void Awake()
        {
            if (!_installEntityOnAwake) return;
            
            _entity.Install();
            _entity.AddTransforms(_transforms);
        }
    }
}