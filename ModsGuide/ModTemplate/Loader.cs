using System;
using System.Reflection;
using Harmony;
using OxygenNotIncluded.Mods.SharedLib;
using UnityEngine;

namespace OxygenNotIncluded.Mods.ModTemplate
{
	public class Loader : LoaderBase<Loader, TranslationMod>
	{
		public void Initialization()
		{
			// if something need to be initialized at load
		}
	}
}
