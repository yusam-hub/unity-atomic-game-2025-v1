using UnityEngine;

namespace Game
{
    public interface ICommandInput
    {
        bool IsMoveRequired { get; }
        Vector2 MousePosition { get; }
    }
}