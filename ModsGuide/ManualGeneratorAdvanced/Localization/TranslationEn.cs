using Ony.OxygenNotIncluded.Lib;

namespace OxygenNotIncluded.Mods.ManualGeneratorAdvanced
{
	[Translation(Language = Localization.Language.Unspecified)]
	public class TranslationEn : TranslationMod
	{
		public override LocalizeText CreateBuildingDef => new LocalizeText( "Loading patch for CreateBuildingDef", "");

	}
}