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
        public void OnLoad(UpdateSystem updateSystem)
        {
            updateSystem.UpdateAt<RoadWearRemoverSystem>(SystemUpdatePhase.PostSimulation);
        }

        public void OnDispose() { }
    }
}
