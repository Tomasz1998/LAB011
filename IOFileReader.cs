using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LAB11
{
    public class IOFileReader : iReader
    {
        public List<Person> ReadPeople(string fileName)
        {
            string[] allData = File.ReadAllLines(fileName);
            var people = allData.Select(x => CSVStringToPersonConverter.Convert(x));
            return people.ToList();
        }
    }
}
