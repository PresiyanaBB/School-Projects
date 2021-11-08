using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalKrai
{
    class Doctor : Hworker
        {
            public override double Salary => staj * 2 + 1500;
        }
}
