using Harmony;
using static Ony.OxygenNotIncluded.Lib.Logger;

namespace OxygenNotIncluded.Mods.ManualGeneratorAdvanced
{
	[HarmonyPatch(typeof(ManualGeneratorConfig), "CreateBuildingDef")]
	class ManualGeneratorConfig_CreateBuildingDef
	{
		public static void Postfix(BuildingDef __result)
		{
			__result.GeneratorWattageRating = 600f;
			Engine.Print(Engine.Localization.CreateBuildingDef.NAME);

		}
	}
}
