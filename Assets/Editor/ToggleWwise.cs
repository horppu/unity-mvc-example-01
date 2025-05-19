using UnityEditor;
using UnityEngine;

public static class WwiseToggle
{
    private const string DefineSymbol = "DISABLE_WWISE";

    [MenuItem("Tools/Wwise/Toggle Wwise Integration")]
    public static void ToggleWwiseDefine()
    {
        BuildTargetGroup buildTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
        string defines = PlayerSettings.GetScriptingDefineSymbolsForGroup(buildTargetGroup);

        if (defines.Contains(DefineSymbol))
        {
            defines = defines.Replace(DefineSymbol, "").Replace(";;", ";").Trim(';');
            Debug.Log("Wwise integration ENABLED.");
        }
        else
        {
            if (!string.IsNullOrEmpty(defines)) defines += ";";
            defines += DefineSymbol;
            Debug.Log("Wwise integration DISABLED.");
        }

        PlayerSettings.SetScriptingDefineSymbolsForGroup(buildTargetGroup, defines);
    }

    [MenuItem("Tools/Wwise/Toggle Wwise Integration", true)]
    public static bool ToggleWwiseDefineValidate()
    {
        Menu.SetChecked("Tools/Wwise/Toggle Wwise Integration", IsWwiseDisabled());
        return true;
    }

    private static bool IsWwiseDisabled()
    {
        BuildTargetGroup buildTargetGroup = EditorUserBuildSettings.selectedBuildTargetGroup;
        string defines = PlayerSettings.GetScriptingDefineSymbolsForGroup(buildTargetGroup);
        return defines.Contains(DefineSymbol);
    }
}

