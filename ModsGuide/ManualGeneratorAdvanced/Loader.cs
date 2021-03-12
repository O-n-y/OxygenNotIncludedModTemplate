using System;
using System.Reflection;
using Harmony;
using Ony.OxygenNotIncluded.Lib;
using UnityEngine;

namespace OxygenNotIncluded.Mods.ManualGeneratorAdvanced
{
	public class Engine : StartUp<Engine, TranslationMod> { }
	public static class Loader
	{
		public static void OnLoad()
		{
			Engine.Start();
		}
	}
}
