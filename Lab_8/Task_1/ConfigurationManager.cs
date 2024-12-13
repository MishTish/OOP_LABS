namespace Task_1
{
    public class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private static readonly object _lock = new object();
        private Dictionary<string, string> _settings;

        // Private constructor to prevent external instantiation
        private ConfigurationManager()
        {
            _settings = new Dictionary<string, string>();
        }

        // Public method to get the single instance
        public static ConfigurationManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigurationManager();
                    }
                }
                return _instance;
            }
        }

        // Method to get a configuration setting
        public string GetSetting(string key)
        {
            return _settings.ContainsKey(key) ? _settings[key] : "Setting not found";
        }

        // Method to set or update a configuration setting
        public void SetSetting(string key, string value)
        {
            _settings[key] = value;
        }

        // Method to display all settings
        public void DisplaySettings()
        {
            Console.WriteLine("\nCurrent Configuration Settings:");
            foreach (var setting in _settings)
            {
                Console.WriteLine($"{setting.Key}: {setting.Value}");
            }
        }
    }

}
