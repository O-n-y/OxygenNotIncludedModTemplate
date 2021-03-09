using Ony.OxygenNotIncluded.Lib;

namespace OxygenNotIncluded.Mods.ManualGeneratorAdvanced
{
	[Translation(Language = Localization.Language.Russian)]
	public class TranslationRu : TranslationMod
	{
		public override LocalizeText LoadingInfo => new LocalizeText( "Русскмй - тест локализации", "");

	}
}