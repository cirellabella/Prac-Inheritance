using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_Inheritance
{
    internal class Plane : Air
    {

        //field
        int _numberOfJets;

        public Plane(string color, int numberOfJets) : base(color)
        {
            _numberOfJets = numberOfJets;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Number of Jets: {_numberOfJets}";
        }

    }
}
