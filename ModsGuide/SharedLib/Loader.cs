using System;
using System.Reflection;
using Ony.OxygenNotIncluded.Lib;

namespace OxygenNotIncluded.Mods.SharedLib
{
	public class LoaderBase<T> where T : class
	{
		public static AssemblyName AssemblyName => Assembly.GetExecutingAssembly().GetName();
		public static Version Version => AssemblyName.Version;
		public static string Name => AssemblyName.Name;
		public static T Localization => LanguageSelection<T>.Get();

		public static void OnLoad()
		{
			Logger.Init(Name);
			
			// Called before any other mod functions (including patches), when Mod is loaded by the Game
			Console.WriteLine($"Mod <{Name}> loaded: {Version}");
		
		}
	}
}
