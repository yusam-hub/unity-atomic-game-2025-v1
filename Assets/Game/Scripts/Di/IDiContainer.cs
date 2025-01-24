using System;

namespace Game
{
    public interface IDiContainer
    {
        void AddService<TContract>(object service);
        object GetService(Type type);
        TContract GetService<TContract>();
    }
}