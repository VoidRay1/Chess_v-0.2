#if ENABLE_EDITOR_GAME_SERVICES
using UnityEditor;

namespace Unity.Services.Analytics.Editor
{
    static class AnalyticsServiceTopMenu
    {
        const int k_ConfigureMenuPriority = 100;
        const string k_ServiceMenuRoot = "Services/Legacy Analytics/";

        [MenuItem(k_ServiceMenuRoot + "Configure", priority = k_ConfigureMenuPriority)]
        static void ShowProjectSettings()
        {
            EditorGameServiceAnalyticsSender.SendTopMenuConfigureEvent();
            var path = AnalyticsSettingsProvider.GetSettingsPath();
            SettingsService.OpenProjectSettings(path);
        }
    }
}
#endif
