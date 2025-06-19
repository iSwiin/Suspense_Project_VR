using UnrealBuildTool;

public class VR_ProjectEditorTarget : TargetRules
{
	public VR_ProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("VR_Project");
	}
}
