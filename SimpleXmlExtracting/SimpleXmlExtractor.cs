using System.Collections.Generic;
using System.IO;
using System.Linq;
using FilesExtraction;
using SimpleXmlNs;

namespace SimpleXmlExtracting
{
    public class SimpleXmlExtractor : IFilesExtractor
    {
        private dynamic _xml;
        
        public void Initialize()
        {
        }

        public void LoadFile(string xmlFilePath)
        {
            _xml = File.ReadAllText(xmlFilePath).AsSimpleXml();
        }

        public IEnumerable<FileDetails> ExtractSoundRecordings()
        {
            IEnumerable<dynamic> files = _xml.ResourceList
                .SoundRecording
                .SoundRecordingDetailsByTerritory
                .TechnicalSoundRecordingDetails
                .File.ToDynamicView();

            return files.Select(f => new FileDetails(f.FileName, f.FilePath, f.HashSum.HashSumAlgorithmType, f.HashSum.HashSum));
        }

        public string Description
        {
            get { return "SimpleXml - http://bitbucket.org/paulshannon/simplexml"; }
        }
    }
}
