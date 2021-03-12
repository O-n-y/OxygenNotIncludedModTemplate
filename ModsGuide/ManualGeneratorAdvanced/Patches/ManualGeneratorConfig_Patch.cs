using Harmony;

namespace OxygenNotIncluded.Mods.ManualGeneratorAdvanced
{
	[HarmonyPatch(typeof(ManualGeneratorConfig), "CreateBuildingDef")]
	class ManualGeneratorConfig_CreateBuildingDef
	{
		public static void Postfix(BuildingDef __result)
		{
			__result.GeneratorWattageRating = 600f;

		//	Header(Loader.Localization.CreateBuildingDef.NAME);
		}
	}
}
