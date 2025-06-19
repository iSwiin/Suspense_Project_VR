using UnrealBuildTool;

public class VR_ProjectClientTarget : TargetRules
{
	public VR_ProjectClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("VR_Project");
	}
}
