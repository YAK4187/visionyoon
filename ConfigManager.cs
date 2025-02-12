using System.IO;

namespace DOT_Number_Reading
{
    public class ConfigManager
    {
        private readonly string filePath;

        // Initialise file path
        public ConfigManager(string filePath)
        {
            this.filePath = filePath;
        }

        // Save config value to file
        public void SaveConfig(string value)
        {
            File.WriteAllText(filePath, value);
        }

        // Load config value from file
        public string LoadConfig()
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath).Trim();
            }
            return null;
        }
    }
}