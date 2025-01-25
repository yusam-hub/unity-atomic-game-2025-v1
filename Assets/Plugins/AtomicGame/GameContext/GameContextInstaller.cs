using System.Collections.Generic;
using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public sealed class GameContextInstaller : SceneContextInstaller<IGameContext>
    {
        [SerializeField]
        private Transform _globalPoolTransform;
        
        protected override void Install(IGameContext context)
        {
            context.AddEntityPool(new PrefabEntityPool(_globalPoolTransform));
        }
    }
}