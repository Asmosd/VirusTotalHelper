using System;
using Microsoft.Win32;

namespace VirusHelperLib
{
    public static class ApiKeyManager
    {
        private const string RegistryKey = "HKEY_CURRENT_USER\\Software\\VirusTotalHelper";
        private const string ApiKeyName = "VTApiKey";

        public static string GetApiKey()
        {
            return (string)Registry.GetValue(RegistryKey, ApiKeyName, null);
        }

        public static void SetApiKey(string apiKey)
        {
            Registry.SetValue(RegistryKey, ApiKeyName, apiKey, RegistryValueKind.String);
        }
    }
}
