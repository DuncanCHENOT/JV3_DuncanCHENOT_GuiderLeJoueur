// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class JV3_DuncanCHENOT_LD : ModuleRules
{
	public JV3_DuncanCHENOT_LD(ReadOnlyTargetRules Target) : base(Target)
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
			"JV3_DuncanCHENOT_LD",
			"JV3_DuncanCHENOT_LD/Variant_Platforming",
			"JV3_DuncanCHENOT_LD/Variant_Platforming/Animation",
			"JV3_DuncanCHENOT_LD/Variant_Combat",
			"JV3_DuncanCHENOT_LD/Variant_Combat/AI",
			"JV3_DuncanCHENOT_LD/Variant_Combat/Animation",
			"JV3_DuncanCHENOT_LD/Variant_Combat/Gameplay",
			"JV3_DuncanCHENOT_LD/Variant_Combat/Interfaces",
			"JV3_DuncanCHENOT_LD/Variant_Combat/UI",
			"JV3_DuncanCHENOT_LD/Variant_SideScrolling",
			"JV3_DuncanCHENOT_LD/Variant_SideScrolling/AI",
			"JV3_DuncanCHENOT_LD/Variant_SideScrolling/Gameplay",
			"JV3_DuncanCHENOT_LD/Variant_SideScrolling/Interfaces",
			"JV3_DuncanCHENOT_LD/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
