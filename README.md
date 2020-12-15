This project is meant to help you start creating mods for the game Oxygen Not Included.

It will provide basic needed information and examples of some mods.

# Requirements:

C# development experience, basic knowledge about reverse engineering

# Tools: 
1. Visual Studio 2019 (https://visualstudio.microsoft.com/vs/), 
2. Resharper (https://www.jetbrains.com/resharper recommended)
3. One of reverse engineering software:  dotPeek (https://www.jetbrains.com/decompiler/) or IL Spy (https://github.com/icsharpcode/ILSpy)



# Project references


## Game .dll

Most .dll you would need located in game subfolder. Locate your game using Steam:
![Game path in Steam](https://raw.githubusercontent.com/O-n-y/OxygenNotIncludedModTemplate/main/Images/oxy-mod-1.png)


You path would look something like:
`E:\Steam\steamapps\common\OxygenNotIncluded`
Move 2 steps down into subfolder:
`E:\Steam\steamapps\common\OxygenNotIncluded\OxygenNotIncluded_Data\Managed`
all .dll we need located in **Managed** subfolder.

## Il Merge

If you planning to add some external .dll to your projects, for example using one core library for all your mods, you would need Il Merge.
You can get it from nuget packages (https://www.nuget.org/packages/ilmerge) or from gihub (https://github.com/dotnet/ILMerge).

I am using version 3.0.29 for .net 4.0


# Mod Template
Let us start making our first mod (code will be available in this repository).

To do so we create new project **.Net 4.0, C# Class Library .Net Framework**:

![Project Type](https://raw.githubusercontent.com/O-n-y/OxygenNotIncludedModTemplate/main/Images/modtemplate-create.png)

Once project created, we adding refferences to minimum count of .dll we could need:
1. 0Harmony.dll
2. Assembly-CSharp.dll
3. Assembly-CSharp-firstpass.dll
4. UnityEngine.dll

![References](https://raw.githubusercontent.com/O-n-y/OxygenNotIncludedModTemplate/main/Images/modtemplate-references.png)

All other we could add later as we need those.

Now we can add Loader - class which will be loaded first once our mod consumed by the Game.

