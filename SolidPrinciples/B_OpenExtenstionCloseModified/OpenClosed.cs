using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.B_OpenExtenstionCloseModified
{
    /// <summary>
    /// Make Class Open For Extension and Close For Modified , by using inheritance and abstraction and make modification for subClasses not super classes
    /// </summary>
    public class OpenForExtendCloseForModified
    {

        public abstract class Employee 
        {
            public int Code { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }

            public abstract double CalcHourValue();

            public override string ToString()
            {
                return Name;
            }
        }

        public class RegularEmployee : Employee
        {
            public override double CalcHourValue()
            {
                return Salary / 30 / 8;
            }
        }

        public class TempEmployee : Employee
        {
            public override double CalcHourValue()
            {
                return Salary / 30 / 12;
            }
        }


    }
}
