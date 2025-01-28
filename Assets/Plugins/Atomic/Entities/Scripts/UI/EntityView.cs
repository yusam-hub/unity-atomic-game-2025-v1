using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Atomic.Entities
{
    [AddComponentMenu("Atomic/Entities/Entity View")]
    [DisallowMultipleComponent]
    public class EntityView : MonoBehaviour
    {
        public virtual string Name => this.name; 
        
        [SerializeField]
        private List<EntityViewInstaller> _installers;

        private readonly List<IEntityBehaviour> _behaviours = new();
        private bool _installed;
        
        [ShowInInspector]
        private IEntity _entity;

        public void Show(IEntity entity)
        {
            this.Install();
            _entity = entity;
            _entity?.AddBehaviours(_behaviours);
            this.gameObject.SetActive(true);
        }

        public void Hide()
        {
            this.gameObject.SetActive(false);
            _entity?.DelBehaviours(_behaviours);
            _entity = null;
        }

        public void AddBehaviour(IEntityBehaviour behaviour)
        {
            _behaviours.Add(behaviour);
            _entity?.AddBehaviour(behaviour);
        }

        public void DelBehaviour(IEntityBehaviour behaviour)
        {
            _behaviours.Remove(behaviour);
            _entity?.DelBehaviour(behaviour);
        }

        private void Install()
        {
            if (_installed)
                return;

            _installed = true;

            for (int i = 0, count = _installers.Count; i < count; i++)
            {
                EntityViewInstaller installer = _installers[i];
                if (installer != null)
                    installer.Install(this);
            }
        }
        
        private void OnDrawGizmosSelected()
        {
            if (_entity == null)
                return;
            
            IReadOnlyCollection<IEntityBehaviour> behaviours = _entity.Behaviours;
            if (behaviours.Count == 0)
                return;

            try
            {
                foreach (IEntityBehaviour behaviour in behaviours)
                {
                    if (behaviour is IEntityGizmos gizmos) 
                        gizmos.OnGizmosDraw(_entity);
                }
            }
            catch (Exception e)
            {
                Debug.LogWarning($"Ops: detected exception in gizmos: {e.Message}");
            }
        }
    }
}