using Exiled.API.Features;
using System;
using Player = Exiled.Events.Handlers.Player;
namespace BetterCandyPorted
{
    public class Plugin : Plugin<Config>
    {
        public override Version RequiredExiledVersion { get; } = new Version(5, 2, 0);
        public override string Name { get; } = "BetterCandy";
        public override Version Version { get; } = new Version(1, 0, 0);

        public Handlers.Player2 player;

        public override void OnEnabled()
        {

            player = new Handlers.Player2(this);
            Exiled.Events.Handlers.Scp330.InteractingScp330 += player.OnInteractingWithScp330;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Scp330.InteractingScp330 -= player.OnInteractingWithScp330;

            player = null;

            base.OnDisabled();
        }
    }
}
