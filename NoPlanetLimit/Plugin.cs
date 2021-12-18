using HarmonyLib;
using Sandbox;
using Sandbox.Game.Entities.Planet;
using Sandbox.Game.World;
using VRage.Plugins;

namespace NoXboxPlanetLimit {
  public class Plugin : IPlugin {

    public Plugin() {
      Log("Patching CanSpawnPlanet");
      var harmony = new Harmony("NoXboxPlanetLimit");
      harmony.PatchAll();
    }

    private static void Log(string msg) {
      MySandboxGame.Log.WriteLineAndConsole($"[NoXboxPlanetLimit] {msg}");
    }

    [HarmonyPatch(typeof(MyPlanets))]
    [HarmonyPatch(nameof(MyPlanets.CanSpawnPlanet))]
    public class Patch {

      static void Prefix() {
        Log("CanSpawnPlanet patch called");
        MySession.Static.Settings.MaxPlanets = 99;
      }

    }

    public void Init(object gameInstance) {
    }

    public void Update() {
    }

    public void Dispose() {
    }
  }
}
