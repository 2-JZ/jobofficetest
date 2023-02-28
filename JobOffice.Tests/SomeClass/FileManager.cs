public class FileManager
{
    public bool IsFileExists(string file)
    {
        if (string.IsNullOrEmpty(file))
        {
            throw new ArgumentNullException("file");
        }
        return File.Exists(file);
    }
}