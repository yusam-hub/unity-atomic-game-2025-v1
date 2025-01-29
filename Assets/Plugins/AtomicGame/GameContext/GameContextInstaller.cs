using Atomic.Contexts;
using Atomic.Elements;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    public sealed class GameContextInstaller : SceneContextInstaller<IGameContext>
    {
        [SerializeField, ReadOnly]
        private ReactiveVariable<int> _score = new();
        protected override void Install(IGameContext context)
        {
            context.AddScore(_score);
        }
    }
}