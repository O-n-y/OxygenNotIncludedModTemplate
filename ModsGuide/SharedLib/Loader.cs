using System;
using System.Reflection;

namespace OxygenNotIncluded.Mods.SharedLib
{
	public class LoaderBase
	{
		public static AssemblyName AssemblyName => Assembly.GetExecutingAssembly().GetName();
		public static Version Version => AssemblyName.Version;
		public static string Name => AssemblyName.Name;

		public static void OnLoad()
		{
			
			// Called before any other mod functions (including patches), when Mod is loaded by the Game
			
			Console.WriteLine($"Mod <{Name}> loaded: {Version}");
		
		}
	}
}
