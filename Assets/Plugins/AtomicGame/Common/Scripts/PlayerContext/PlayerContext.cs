using Atomic.Contexts;

namespace AtomicGame.Common
{
    public interface IPlayerContext : IContext
    {
    }

    public sealed class PlayerContext : SceneContext, IPlayerContext
    {
    }
}