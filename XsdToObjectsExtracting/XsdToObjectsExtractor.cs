using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using FilesExtraction;
using XsdToObjectsExtracting.Generated;

namespace XsdToObjectsExtracting
{
    public class XsdToObjectsExtractor : IFilesExtractor
    {
        private NewReleaseMessage _msg;

        public void LoadFile(string xmlFilePath)
        {
            _msg = new NewReleaseMessage(XDocument.Load(xmlFilePath).Elements().Single());
        }

        public IEnumerable<FileDetails> ExtractSoundRecordings()
        {
            return _msg.ResourceList.SoundRecordings
                .SelectMany(rec => rec.SoundRecordingDetailsByTerritorys)
                .SelectMany(det => det.TechnicalSoundRecordingDetails)
                .SelectMany(techDet => techDet.Files)
                .Select(f => new FileDetails(f.FileName,
                    f.FilePath,
                    f.HashSum.HashSumAlgorithmType,
                    f.HashSum.HashSumProp));
        }

        public string Description
        {
            get { return "XsdToObject - http://github.com/7digital/XsdToObject"; }
        }
    }
}
