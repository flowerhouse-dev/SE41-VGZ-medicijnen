using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VgzMedicijnenApp.Domain
{
    public class Drug
    {
        public string Name { get; set; }
        public string Dose { get; set; }
        public string Instructions { get; set; }

        public Drug(string name, string dose, string instructions)
        {
            Name = name;
            Dose = dose;
            Instructions = instructions;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
