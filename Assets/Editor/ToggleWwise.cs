#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

public static class WwiseToggle
{
    private const string DefineSymbol = "DISABLE_WWISE";

    [MenuItem("Tools/Wwise/Disable Wwise Events")]
    public static void ToggleWwiseDefine()
    {
        var buildTargetGroup = UnityEditor.Build.NamedBuildTarget.FromBuildTargetGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
        string defines = PlayerSettings.GetScriptingDefineSymbols(buildTargetGroup);

        if (defines.Contains(DefineSymbol))
        {
            defines = defines.Replace(DefineSymbol, "").Replace(";;", ";").Trim(';');
            Debug.Log("Wwise Events ENABLED.");
        }
        else
        {
            if (!string.IsNullOrEmpty(defines)) defines += ";";
            defines += DefineSymbol;
            Debug.Log("Wwise Events DISABLED.");
        }

        PlayerSettings.SetScriptingDefineSymbols(buildTargetGroup, defines);
    }

    [MenuItem("Tools/Wwise/Disable Wwise Events", true)]
    public static bool ToggleWwiseDefineValidate()
    {
        Menu.SetChecked("Tools/Wwise/Disable Wwise Events", IsWwiseDisabled());
        return true;
    }

    private static bool IsWwiseDisabled()
    {
        var buildTargetGroup = UnityEditor.Build.NamedBuildTarget.FromBuildTargetGroup(EditorUserBuildSettings.selectedBuildTargetGroup);
        string defines = PlayerSettings.GetScriptingDefineSymbols(buildTargetGroup);
        return defines.Contains(DefineSymbol);
    }
}
#endif

