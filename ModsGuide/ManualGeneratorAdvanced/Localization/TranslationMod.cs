using Ony.OxygenNotIncluded.Lib;

namespace OxygenNotIncluded.Mods.ManualGeneratorAdvanced
{
	public class TranslationMod : TranslationBase
	{
		public virtual LocalizeText CreateBuildingDef => LanguageSelection<TranslationMod>.Get().CreateBuildingDef;

	}
}
