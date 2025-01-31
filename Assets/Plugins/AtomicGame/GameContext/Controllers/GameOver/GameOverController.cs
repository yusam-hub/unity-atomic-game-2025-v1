using Atomic.Contexts;
using UnityEngine;

namespace AtomicGame
{
    public class GameOverController : IContextInit<IGameContext>, IContextUpdate<IGameContext>
    {
        private Cooldown _gameOver;
        private bool _waiting = true;

        public GameOverController(Cooldown gameOver)
        {
            _gameOver = gameOver;
        }

        public void Init(IGameContext context)
        {
            context.GetGameOverBeginEvent().Subscribe(() =>
            {
                _gameOver.Reset();
                _waiting = false;
            });
        }

        public void OnUpdate(IGameContext context, float deltaTime)
        {
            if (_waiting) return;
            
            _gameOver.Tick(deltaTime);
            
            if (_gameOver.IsExpired())
            {
                _waiting = true;
                context.GetGameOverEndEvent().Invoke();
            }
        }
    }
}