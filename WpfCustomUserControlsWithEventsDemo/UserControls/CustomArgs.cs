using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCustomUserControlsWithEventsDemo.UserControls
{
    internal class CustomArgs // This custom event argument class bears entered name and age
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public CustomArgs(string name, string age)
        {
            Name = name;
            Age = age;
        }   
    }
}
