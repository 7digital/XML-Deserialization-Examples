using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using FilesExtraction;

namespace XElementExtracting
{
    public class XElementExtractor : IFilesExtractor
    {
        private XDocument _doc;

        public void LoadFile(string xmlFilePath)
        {
            _doc = XDocument.Load(xmlFilePath);
        }

        public IEnumerable<FileDetails> ExtractSoundRecordings()
        {
            return _doc.Descendants("SoundRecording")
                .SelectMany(rec => rec.Descendants("File"))
                .Select(file => new FileDetails(file.Element("FileName").Value,
                    file.Element("FilePath").Value,
                    file.Element("HashSum").Element("HashSumAlgorithmType").Value,
                    file.Element("HashSum").Element("HashSum").Value));
        }

        public string Description
        {
            get { return "XDocument/XElement"; }
        }
    }
}
