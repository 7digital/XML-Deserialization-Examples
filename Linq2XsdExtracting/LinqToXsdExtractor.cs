using System.Collections.Generic;
using System.Linq;
using FilesExtraction;
using ddex_net.xml.ern._341;

namespace Linq2XsdExtracting
{
    public class LinqToXsdExtractor : IFilesExtractor
    {
        private NewReleaseMessage _doc;

        public void LoadFile(string xmlFilePath)
        {
            _doc = NewReleaseMessage.Load(xmlFilePath);
        }

        public IEnumerable<FileDetails> ExtractSoundRecordings()
        {
            return _doc.ResourceList.SoundRecording
                .SelectMany(rec => rec.SoundRecordingDetailsByTerritory)
                .SelectMany(det => det.TechnicalSoundRecordingDetails)
                .SelectMany(tech => tech.File)
                .Select(f => new FileDetails(f.FileName,
                    f.FilePath,
                    f.HashSum.HashSumAlgorithmType.TypedValue,
                    f.HashSum.HashSum1));
        }

        public string Description
        {
            get { return "LINQ to XSD - http://linqtoxsd.codeplex.com"; }
        }
    }
}
