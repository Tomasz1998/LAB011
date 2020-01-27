using System;
using System.Collections.Generic;
using System.Text;

namespace LAB11
{
    public interface iReader
    {
        List<Person> ReadPeople(string fileName);
    }
}
