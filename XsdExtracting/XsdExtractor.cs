using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using FilesExtraction;
using XsdExtracting.Generated;
using File = XsdExtracting.Generated.File;

namespace XsdExtracting
{
    public class XsdExtractor : IFilesExtractor
    {
        private XmlSerializer _serializer;
        private NewReleaseMessage _msg;

        public void Initialize()
        {
            _serializer = new XmlSerializer(typeof(NewReleaseMessage));
        }

        public void LoadFile(string xmlFilePath)
        {
            using (Stream stream = new FileStream(xmlFilePath, FileMode.Open, FileAccess.Read))
                _msg = (NewReleaseMessage)_serializer.Deserialize(stream);
        }

        public IEnumerable<FileDetails> ExtractSoundRecordings()
        {
            return _msg.ResourceList.SoundRecording.SelectMany(rec => rec.SoundRecordingDetailsByTerritory)
               .SelectMany(det => det.TechnicalSoundRecordingDetails)
               .SelectMany(tech => tech.Items.OfType<File>())
               .Select(f => new FileDetails(f.Items[0],
                   f.Items[1],
                   f.HashSum.HashSumAlgorithmType.Value.ToString(),
                   f.HashSum.HashSum1));
        }

        public string Description
        {
            get { return "Microsoft XSD.exe/XmlSerializer"; }
        }
    }
}
