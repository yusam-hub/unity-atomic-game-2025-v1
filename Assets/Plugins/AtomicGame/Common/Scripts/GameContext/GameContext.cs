using Atomic.Contexts;

namespace AtomicGame.Common
{
    public interface IGameContext : IContext
    {
    }

    public sealed class GameContext : SingletonSceneContext<GameContext>, IGameContext
    {
    }
}