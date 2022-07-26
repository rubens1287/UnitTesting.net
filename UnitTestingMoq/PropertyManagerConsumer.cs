using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingMoq
{
    public class PropertyManagerConsumer
    {
        private readonly IPropertyManager _propertyManager;

        public PropertyManagerConsumer(IPropertyManager propertyManager)
        {
            _propertyManager = propertyManager;
        }

        public void ChangeName(string name)
        {
            _propertyManager.FirstName = name;
        }

        public string GetName()
        {
            return _propertyManager.FirstName;
        }

        public void ChangeRemoteName(string name)
        {
            _propertyManager.MutateFirstName(name);
        }
    }
}
