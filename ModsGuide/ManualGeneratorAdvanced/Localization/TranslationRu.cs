using Ony.OxygenNotIncluded.Lib;

namespace OxygenNotIncluded.Mods.ManualGeneratorAdvanced
{
	[Translation(Language = Localization.Language.Russian)]
	public class TranslationRu : TranslationMod
	{
		public override LocalizeText CreateBuildingDef => new LocalizeText( "Загрузка патча для CreateBuildingDef -> установка вывода мощности на 600", "");

	}
}