using Atomic.Contexts;

namespace AtomicGame
{
    public interface IGameContext : IContext
    {
    }

    public sealed class GameContext : SingletonSceneContext<GameContext>, IGameContext
    {
    }
}