using UnrealBuildTool;

public class VR_ProjectTarget : TargetRules
{
	public VR_ProjectTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("VR_Project");
	}
}
