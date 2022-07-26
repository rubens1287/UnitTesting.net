using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingMoq
{
    public class PropertyManager : IPropertyManager
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void MutateFirstName(string name)
        {
            this.FirstName = name;
        }
    }
}
