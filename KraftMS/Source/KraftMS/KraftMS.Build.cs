// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class KraftMS : ModuleRules
{
	public KraftMS(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"KraftMS",
			"KraftMS/Variant_Platforming",
			"KraftMS/Variant_Platforming/Animation",
			"KraftMS/Variant_Combat",
			"KraftMS/Variant_Combat/AI",
			"KraftMS/Variant_Combat/Animation",
			"KraftMS/Variant_Combat/Gameplay",
			"KraftMS/Variant_Combat/Interfaces",
			"KraftMS/Variant_Combat/UI",
			"KraftMS/Variant_SideScrolling",
			"KraftMS/Variant_SideScrolling/AI",
			"KraftMS/Variant_SideScrolling/Gameplay",
			"KraftMS/Variant_SideScrolling/Interfaces",
			"KraftMS/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
