using System;
using System.Reflection;
using Harmony;
using Ony.OxygenNotIncluded.Lib;
using UnityEngine;

namespace OxygenNotIncluded.Mods.ModTemplate
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