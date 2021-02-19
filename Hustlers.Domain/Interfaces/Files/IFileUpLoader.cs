using System.IO;

namespace Hustlers.Domain.Interfaces.Files
{
    public interface IFileUpLoader
    {
        string UploadFile(Stream fileStream, string filename, string contentType);
    }
}
