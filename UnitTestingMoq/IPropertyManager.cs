using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingMoq
{
    public interface IPropertyManager
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        void MutateFirstName(string name);
    }
}
