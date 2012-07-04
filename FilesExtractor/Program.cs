﻿using System;
using System.Collections.Generic;
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
        public static void Main()
        {
            IList<IFilesExtractor> extractors = new List<IFilesExtractor>
            {                
                new XsdExtractor(),
                new XElementExtractor(),
                new SimpleXmlExtractor(),
                new LinqToXsdExtractor(),                
                new XsdToObjectsExtractor()
            };

            foreach (IFilesExtractor extractor in extractors)
                Console.WriteLine("{0}: {1}", extractor.GetType().Name, extractor.Description);

            Console.WriteLine("\nRunning extractors...");

            foreach (IFilesExtractor extractor in extractors)
                Extract(extractor);

            Console.WriteLine("Done.");
            Console.ReadKey();
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
            return total / count;
        }

        public static void Extract(IFilesExtractor extractor)
        {
            try
            {
                double initTime = Measure(extractor.Initialize);
                double loadTime = Measure(() => extractor.LoadFile("ddexTest.xml"));
                double accessTime = MeasureAvg(() => extractor.ExtractSoundRecordings(), 100);

                Console.WriteLine("{0}: Init:{1:0.0}ms, Load:{2:0.0}ms, Access:{3:0.0}ms, Total:{4:0.0}ms",
                    extractor.GetType().Name,
                    initTime, loadTime, accessTime, 
                    initTime + loadTime + accessTime);

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} failed: {1}", extractor.GetType().Name, e.Message);
            }
        }


    }
}