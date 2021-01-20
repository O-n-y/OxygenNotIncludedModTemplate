using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Epic.OnlineServices.Stats;
using Harmony;

namespace ManualGeneratorAdvanced.Patches
{
	[HarmonyPatch(typeof(ManualGeneratorConfig), "CreateBuildingDef")]
	class ManualGeneratorConfig_CreateBuildingDef
	{
		public static void Postfix(BuildingDef __result)
		{
			__result.GeneratorWattageRating = 600f;
		}
	}
}
