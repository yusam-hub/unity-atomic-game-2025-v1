using UnityEngine;

namespace Game
{
    public sealed class DiContainerInstaller : Installer
    {
        [SerializeField]
        private Character character;

        [SerializeField]
        private DirectionVector3 directionInput;

        [SerializeField]
        private new Camera camera;

        public override void Install(IDiContainer container)
        {
            container.AddService<ICharacter>(this.character);
            container.AddService<IDirectionVector3>(this.directionInput);
            container.AddService<Camera>(this.camera);
        }
    }
}