using Colossal.Logging;
using Colossal.Serialization.Entities;
using Game;
using Game.Audio;
using Game.Prefabs;
using Game.Rendering;
using Game.Simulation;
using Unity.Entities;
using UnityEngine;
using UnityEngine.Scripting;

namespace RoadWearRemoverPDX
{
    public partial class RoadWearRemoverSystem : GameSystemBase
    {
        protected override void OnGameLoaded(Context serializationContext) {
            Shader shader = Shader.Find("BH/Decals/CurvedDecalDeteriorationShader");
            World.GetExistingSystemManaged<RenderingSystem>().SetShaderEnabled(shader, false);
        }

        protected override void OnUpdate() { }
    }
}
