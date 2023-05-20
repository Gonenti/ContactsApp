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
        /// Path to json file.
        /// </summary>
        private readonly string _pathToFile;

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
        private readonly string APP_NAME = "project.json";

        /// <summary>
        /// Gets the file name of the serialized project.
        /// </summary>
        public string FileName => FILE_NAME;

        /// <summary>
        /// Gets the developer name
        /// </summary>
        public string DeveloperName => DEVELOPER_NAME;

        /// <summary>
        /// Gets the APP name
        /// </summary>
        public string AppName => APP_NAME;

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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectSerializer"/> class with class.
        /// </summary>
        public ProjectSerializer(string path)
        {
            _pathToFile = path;
            CreateFolder(_pathToFile);
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
            catch (FileNotFoundException)
            {
                 throw new FileNotFoundException($"File not found: {Path.Combine(_pathToFile, FILE_NAME)}");
            }
            catch (JsonReaderException ex)
            {
                throw new JsonReaderException($"Error reading file: {ex.Message}");
            }
            catch (IOException ex)
            {
                throw new IOException($"Error loading file: {ex.Message}");
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
