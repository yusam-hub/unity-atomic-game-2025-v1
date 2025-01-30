using Atomic.Contexts;
using Atomic.Entities;
using UnityEngine;

namespace AtomicGame
{
    public sealed class CharacterInteractController : IContextInit<IPlayerContext>, IContextUpdate
    {
        private IEntity _character;
        private IPlayerContext _context;

        public void Init(IPlayerContext context)
        {
            _character = context.GetCharacter();
            _context = context;
        }

        public void OnUpdate(IContext context, float deltaTime)
        {
            if (InputUseCase.IsInteract(_context))
            {
                InteractUseCase.InteractAsCharacter(_character);
            }
        }
    }
}