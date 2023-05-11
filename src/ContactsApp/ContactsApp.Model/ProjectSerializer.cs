namespace ContactsApp.Model
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ProjectSerializer
{
    private readonly string _pathToFile;
    private readonly string _filename;

    public string Filename => _filename;

    public ProjectSerializer()
    {
        _pathToFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                 "Olimov",
                                 "ContactApp"
                                 );
        CreateFolder(_pathToFile);
        _filename = "project.json";


    }

    public void SaveToFile(Project project)
    {
        CreateFolder(_pathToFile);
        try
        {
            var json = JsonConvert.SerializeObject(project, Formatting.Indented);
            File.WriteAllText(
                Path.Combine(_pathToFile, _filename), 
                json);
        }
        catch (IOException ex)
        {
            throw new IOException($"Error saving file: {ex.Message}");
        }
    }

    public Project LoadFromFile()
    {
        CreateFolder(_pathToFile);
        try
        {
            var json = File.ReadAllText(Path.Combine(_pathToFile, _filename));
            var project = JsonConvert.DeserializeObject<Project>(json);
            return project ?? new Project();
        }
        catch (FileNotFoundException)
        {
             throw new FileNotFoundException($"File not found: {Path.Combine(_pathToFile, _filename)}");
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
    /// Create folder if folder does't exist
    /// </summary>
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
