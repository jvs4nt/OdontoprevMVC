using System;

namespace OdontoprevApi.Utils
{
    public sealed class ConfigManager
    {
        private static readonly Lazy<ConfigManager> _instance = 
            new Lazy<ConfigManager>(() => new ConfigManager());

        public static ConfigManager Instance => _instance.Value;

        public string AppName { get; private set; }

        private ConfigManager()
        {
            // Exemplo de carregamento de configuração
            AppName = "Odontoprev API";
        }
    }
}