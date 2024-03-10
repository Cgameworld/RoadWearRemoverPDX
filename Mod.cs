using Colossal.Logging;
using Game;
using Game.Modding;
using Game.Rendering;
using Game.SceneFlow;
using Unity.Entities;
using UnityEngine;

namespace RoadWearRemoverPDX
{
    public class Mod : IMod
    {
        //public static ILog log = LogManager.GetLogger($"{nameof(RoadWearRemoverPDX)}.{nameof(Mod)}").SetShowsErrorsInUI(false);

        public void OnLoad(UpdateSystem updateSystem)
        {
            //log.Info(nameof(OnLoad));

            //if (GameManager.instance.modManager.TryGetExecutableAsset(this, out var asset))
               // log.Info($"11 Current mod asset at {asset.path}");

            updateSystem.UpdateAt<RoadWearRemoverSystem>(SystemUpdatePhase.PostSimulation);

           // log.Info("system updated?");
        }

        public void OnDispose() { }
    }
}
