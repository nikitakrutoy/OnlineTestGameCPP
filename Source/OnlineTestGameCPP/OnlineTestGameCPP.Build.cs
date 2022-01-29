// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class OnlineTestGameCPP : ModuleRules
{
	public OnlineTestGameCPP(ReadOnlyTargetRules Target) : base(Target)
	{
		
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", 
			"OnlineSubsystem", "OnlineSubsystemUtils"
		});
		
		DynamicallyLoadedModuleNames.Add("OnlineSubsystemSteam");
		
		// Uncomment if you are using online features
		PrivateDependencyModuleNames.Add("OnlineSubsystem");
	}
}
