using System;
using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame.Common
{
    [Serializable]
    public sealed class CharacterSystemInstaller : IContextInstaller<IPlayerContext>
    {
        [SerializeField]
        private SceneEntity _character;

        public void Install(IPlayerContext context)
        {
            context.AddCharacter(_character);
            context.AddController<CharacterMoveController>();
            context.AddController<CharacterJumpController>();
        }
    }
}