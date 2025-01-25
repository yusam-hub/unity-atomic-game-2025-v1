using Atomic.Contexts;

namespace AtomicGame
{
    public interface IPlayerContext : IContext
    {
    }

    public sealed class PlayerContext : SceneContext, IPlayerContext
    {
    }
}