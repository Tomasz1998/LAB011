using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LAB11
{
    public class Writer
    {
        public void WriteToFile(Person person, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.Write($"[{person.Id}] {person.Name} {person.LastName}: {person.Phone}");
            }
        }
        public void WritePhone(IEnumerable<Person> persons, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                List<Person> lista = persons.ToList();
                for (int i = 0; i < lista.Count; i++)
                {
                    writer.WriteLine($"[{lista[i].Phone}]");
                }
                
            }
        }
        public void ZapiszTelefonCo10(IEnumerable<Person> persons)
        {
            List<Person> mojaLista = persons.ToList();

            string fileName;
            string prefix = "result-10-numerow-part-";
            int dziel = 0;

            while (mojaLista.Count > dziel * 10)
            {
                fileName = prefix + ++dziel + ".txt";

                using (StreamWriter writer = new StreamWriter(fileName))
                {

                    var nastepneLinie = mojaLista.Skip((dziel - 1) * 10).Take(10);

                    foreach (var item in nastepneLinie)
                    {
                        writer.WriteLine($"[{item.Phone}, {item.LastName}]");
                    }
                }
            }
        }

    }
}
