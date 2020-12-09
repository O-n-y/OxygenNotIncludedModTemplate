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

You path would look something like:
`E:\Steam\steamapps\common\OxygenNotIncluded`
Move 2 steps down into subfolder:
`E:\Steam\steamapps\common\OxygenNotIncluded\OxygenNotIncluded_Data\Managed`
all .dll we need located in **Managed** subfolder.

## Il Merge

If you planning to add some external .dll to your projects, for example using one core library for all your mods, you would need Il Merge.
You can get it from nuget packages (https://www.nuget.org/packages/ilmerge) or from gihub (https://github.com/dotnet/ILMerge).

I am using version 3.0.29 for .net 4.0


