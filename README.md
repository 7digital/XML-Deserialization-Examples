XML Deserialization Examples
===========
The purpose of this project is to present different approaches of xml mapping to own domain classes.

The FilesExtractor app deserializes the same xml using following approaches:
* Microsoft XSD.exe to map XSD to classes and XmlSerializer class to deserialize xml
* standard XDocument class to load xml and XElement class to browse document data
* SimpleXml library (http://bitbucket.org/paulshannon/simplexml) to load and browse xml
* LINQ to XSD library (http://linqtoxsd.codeplex.com) to map XSD to classes and then use them to load xml
* XsdToObject (http://github.com/7digital/XsdToObject) to map XSD to classes and XDocument to load xml

The FilesExtractor shows statistics of:
* xml load time
* total data accessing time
* total time

The statistics are taken for:
* 1 data access
* 1 data access (to show difference between framework initalization and normal usage)
* 100 data accesses
* 1000 data accesses
* 10000 data accesses