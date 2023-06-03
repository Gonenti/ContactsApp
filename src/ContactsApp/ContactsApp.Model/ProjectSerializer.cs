namespace ContactsApp.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Serializes and deserializes the <see cref="Project"/> class to/from a JSON file.
    /// </summary>
    public class ProjectSerializer
    {
        /// <summary>
        /// Name of the json file
        /// </summary>
        private readonly string FILE_NAME = "project.json";

        /// <summary>
        /// Developer name
        /// </summary>
        private readonly string DEVELOPER_NAME = "Olimov";

        /// <summary>
        /// Programm name
        /// </summary>
        private readonly string APP_NAME = "ContactApp";

        /// <summary>
        /// Path to json file.
        /// </summary>
        private readonly string _pathToFile;

        /// <summary>
        /// Path to file property.
        /// </summary>
        public string PathToFile => _pathToFile;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSerializer"/> class.
        /// </summary>
        public ProjectSerializer()
        {
            _pathToFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                     DEVELOPER_NAME,
                                     APP_NAME
                                     );

            CreateFolder(_pathToFile);
            CreateJsonFileInFolder(_pathToFile);
        }

        /// <summary>
        /// Saves the specified <paramref name="project"/> to a JSON file.
        /// </summary>
        /// <param name="project">The project to be saved.</param>
        public void SaveToFile(Project project)
        {
            CreateFolder(_pathToFile);
            try
            {
                var json = JsonConvert.SerializeObject(project, Formatting.Indented);
                File.WriteAllText(
                    Path.Combine(_pathToFile, FILE_NAME), 
                    json);
            }
            catch (IOException ex)
            {
                throw new IOException($"Error saving file: {ex.Message}");
            }
        }
        
         /// <summary>
         /// Loads a project from the JSON file.
         /// </summary>
         /// <returns>The loaded <see cref="Project"/> object.</returns>
         public Project LoadFromFile()
         {
            CreateFolder(_pathToFile);
            try
            {
                var json = File.ReadAllText(Path.Combine(_pathToFile, FILE_NAME));
                var project = JsonConvert.DeserializeObject<Project>(json);
                return project ?? new Project();
            }
            catch (ArgumentException error)
            {
                 throw new FileNotFoundException($"Error: {error.Message}");
            }
        }

        /// <summary>
        /// Creates a folder at the specified <paramref name="folder"/> path if it doesn't exist.
        /// </summary>
        /// <param name="folder">The path to the folder.</param>
        public void CreateFolder(string folder) 
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }; 
        }

        /// <summary>
        /// Creates a file in the folder <paramref name="folder"/> 
        /// </summary>
        /// <param name="folder">The path to the folder.</param>
        public void CreateJsonFileInFolder(string folder)
        {
            if (Directory.Exists(folder))
            {
                JObject project = new JObject();
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(Path.Combine(folder, "project.json")))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, project);
                }
            };
        }
    }
}
