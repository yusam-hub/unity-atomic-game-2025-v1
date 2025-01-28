using UnityEngine;

namespace Atomic.Entities
{
    [AddComponentMenu("Atomic/Entities/Entity Proxy")]
    [DisallowMultipleComponent]
    public class SceneEntityProxy : SceneEntityProxy<SceneEntity>
    {
    }

    public abstract partial class SceneEntityProxy<E> : MonoBehaviour, IEntity where E : SceneEntity
    {
        [SerializeField]
        public E _source;

        public int Id
        {
            get { return _source.Id; }
            set { _source.Id = value; }
        }

        public string Name
        {
            get => _source.Name;
            set => _source.Name = value;
        }
        
        public void Clear()
        {
            _source.Clear();
        }

        public void Destruct()
        {
            _source.Destruct();
        }

        public override bool Equals(object obj)
        {
            return obj is IEntity entity && _source.Id == entity.Id;
        }

        public override int GetHashCode()
        {
            return _source.GetHashCode();
        }

        private void Reset()
        {
            _source = this.GetComponentInParent<E>();
        }
    }
}