using Atomic.Contexts;
using Atomic.Entities;

namespace AtomicGame
{
    public class CharacterMoveController : IContextInit<IPlayerContext>, IContextUpdate
    {
        private IEntity _character;
        private IPlayerContext _context;

        public void Init(IPlayerContext context)
        {
            _context = context;
            _character = context.GetCharacter();
        }

        public void OnUpdate(IContext context, float deltaTime)
        {
            _character.GetMoveAction().Invoke(InputUseCase.GetMoveDirection(_context), deltaTime);
        }
    }
}