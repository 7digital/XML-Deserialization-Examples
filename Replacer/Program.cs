using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using ddex_net.xml.ern._341;

namespace Replacer
{
    class Program
    {
        class TextGenerator
        {
            public string Generate()
            {
                return Guid.NewGuid().ToString().Replace("-", "f").Replace("{", "a").Replace("}", "z");
            }
        }

        static void Main(string[] args)
        {
            /*LinkedList<object> checkedObjects = new LinkedList<object>();
            LinkedList<object> objectsToCheck = new LinkedList<object>();
            var msg = NewReleaseMessage.Load("..\\..\\..\\FilesExtractor\\ddexTest.xml");
            objectsToCheck.AddLast(msg);
            Replace(objectsToCheck, new TextGenerator(), checkedObjects);
            msg.Save("out.xml");*/

            var gen = new TextGenerator();
            XDocument doc = XDocument.Load("..\\..\\..\\FilesExtractor\\ddexTest.xml");
            foreach (var e in doc.Descendants().Where(e => !e.HasElements))
                e.Value = gen.Generate();
            doc.Save("out.xml");
        }

        private static void Replace(LinkedList<object> objsToCheck, TextGenerator textGenerator, LinkedList<object> checkedObjects)
        {
            while (objsToCheck.Count > 0)
            {
                object obj = objsToCheck.First;
                objsToCheck.RemoveFirst();                
                Replace(obj, textGenerator, checkedObjects, objsToCheck);
            }
        }

        private static void Replace(object obj, TextGenerator textGenerator, LinkedList<object> checkedObjects, LinkedList<object> objsToCheck)
        {
            if (obj == null || checkedObjects.Any(o => obj == o))
                return;
            checkedObjects.AddLast(obj);

            foreach (var prop in obj.GetType().GetProperties())
            {
                try
                {
                    if (prop.PropertyType == typeof(string))
                    {

                        prop.SetValue(obj, textGenerator.Generate(), null);

                    }
                    else if (typeof(IEnumerable).IsAssignableFrom(prop.PropertyType))
                        ReplaceList((IEnumerable)prop.GetValue(obj, null), objsToCheck);
                    else if (!prop.PropertyType.IsPrimitive)
                        objsToCheck.AddLast(prop.GetValue(obj, null));
                }
                catch (Exception) { }
            }
        }

        private static void ReplaceList(IEnumerable enums, LinkedList<object> objsToCheck)
        {
            foreach (var o in enums)
                objsToCheck.AddLast(o);
            
        }
    }
}
