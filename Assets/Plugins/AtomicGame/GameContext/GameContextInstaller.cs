using System.Collections.Generic;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Sirenix.OdinInspector;
using UnityEngine;

namespace AtomicGame
{
    public sealed class GameContextInstaller : SceneContextInstaller<IGameContext>
    {
        /*[SerializeField]
        private Transform _globalPoolTransform;*/

        [SerializeField, ReadOnly]
        private ReactiveVariable<int> _score = new();
        protected override void Install(IGameContext context)
        {
            //context.AddEntityPool(new PrefabEntityPool(_globalPoolTransform));
            context.AddScore(_score);
        }
    }
}