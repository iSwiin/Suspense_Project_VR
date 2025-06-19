using UnrealBuildTool;

public class VR_ProjectServerTarget : TargetRules
{
	public VR_ProjectServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("VR_Project");
	}
}
