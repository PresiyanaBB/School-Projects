using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalKrai
{
    class Nurse : Hworker
    {
        public override double Salary => pacienti * 3 + 100;
    }
}
