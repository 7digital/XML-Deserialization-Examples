using System;
using System.Collections.Generic;
using System.Linq;
using FilesExtraction;
using Linq2XsdExtracting;
using SimpleXmlExtracting;
using XElementExtracting;
using XsdExtracting;
using XsdToObjectsExtracting;

namespace FilesExtractor
{
    public class Program
    {
        private static IList<IFilesExtractor> extractors = new List<IFilesExtractor>
        {
            new XsdExtractor(),
            new XElementExtractor(),
            new SimpleXmlExtractor(),
            new LinqToXsdExtractor(),
            new XsdToObjectsExtractor()
        };

        public static void Main()
        {
            for (int i = 0; i < extractors.Count; ++i)
                Console.WriteLine("{0}={1} - {2}", i + 1, extractors[i].GetType().Name, extractors[i].Description);

            RunExtractors(1);
            RunExtractors(1);
            RunExtractors(100);
            RunExtractors(1000);
            RunExtractors(10000);

            Console.WriteLine("\nDone.");
            Console.ReadKey();
        }

        private static void RunExtractors(int reads)
        {
            Console.WriteLine("\nRunning extractors - {0} read(s)...", reads);
            for (int i = 0; i < extractors.Count; ++i)
                Extract(extractors[i], i + 1, reads);
        }

        private static double Measure(Action action)
        {
            DateTime start = DateTime.UtcNow;
            action();
            DateTime end = DateTime.UtcNow;
            return (end - start).TotalMilliseconds;
        }

        private static double MeasureAvg(Action action, int count)
        {
            double total = 0;
            for (int i = 0; i < count; i++)
                total += Measure(action);
            return total;
        }

        public static void Extract(IFilesExtractor extractor, int idx, int reads)
        {
            try
            {
                double loadTime = Measure(() => extractor.LoadFile("ddexTest.xml"));
                double accessTime = MeasureAvg(() => extractor.ExtractSoundRecordings(), reads);

                Console.WriteLine("{0}: Load: {1,6:0.0}ms, Access: {2,5:0.0}ms, Total: {3,6:0.0}ms",
                    idx, loadTime, accessTime,
                    loadTime + accessTime);

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} failed: {1}", extractor.GetType().Name, e.Message);
            }
        }


    }
}
