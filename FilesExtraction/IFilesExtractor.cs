using System.Collections.Generic;

namespace FilesExtraction
{
    public interface IFilesExtractor
    {
        void LoadFile(string xmlFilePath);
        IEnumerable<FileDetails> ExtractSoundRecordings();
        string Description { get; }
    }

    public class FileDetails
    {
        public FileDetails(string name, string path, string hashAlgorithm, string hash)
        {
            Name = name;
            Path = path;
            HashAlgorithm = hashAlgorithm;
            Hash = hash;
        }

        public string Name { get; set; }
        public string Path { get; set; }
        public string HashAlgorithm { get; set; }
        public string Hash { get; set; }
    }
}
