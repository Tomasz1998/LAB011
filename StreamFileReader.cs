using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
namespace LAB11
{
    public class StreamFileReader : iReader
    {
        public List<Person> ReadPeople(string fileName)
        {
            string data;
            using (var reader = new StreamReader(fileName))
            {
                data = reader.ReadToEnd();
            }
            string[] lines = data.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var people = lines.Select(x => CSVStringToPersonConverter.Convert(x));
            return people.ToList();
        }
    }
}
