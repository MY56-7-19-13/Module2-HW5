using Newtonsoft.Json;

namespace Homework5
{
    public class FileService
    {
        public void SerializationSample(string message)
        {
            var configFile = File.ReadAllText("../../../config.json");
            var config = JsonConvert.DeserializeObject<Config>(configFile);
            string directoryPath = config.Logger.DirectoryPath;
            DirectoryInfo directory = new DirectoryInfo(directoryPath);
            FileInfo[] files = directory.GetFiles();
            config.Logger.TimeFormat = $"{DateTime.Now.Hour}.{DateTime.Now.Minute}.{DateTime.Now.Second} {DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year}";
            string fileName = $"{config.Logger.TimeFormat}.txt";
            string filePath = directory + fileName;

            using (StreamWriter file = new StreamWriter(filePath, true))
            {
                file.WriteLine(message);
            }

            if (files.Length > 3)
            {
                files[0].Delete();
            }
        }
    }
}
