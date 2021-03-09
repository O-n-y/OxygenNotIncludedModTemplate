using Ony.OxygenNotIncluded.Lib;

namespace OxygenNotIncluded.Mods.ManualGeneratorAdvanced
{
	public class TranslationMod : TranslationBase
	{
		public virtual LocalizeText LoadingInfo => LanguageSelection<TranslationMod>.Get().LoadingInfo;

	}
}
