using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqStuff.Tests
{
    public record class Person(
        string FirstName, string LastName, string MiddleName, string Age)
    {
    }
}
