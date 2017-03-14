using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculator
{

    public class band
    {
        public band()
        { }

        public double sal { get; set; }
        public double ta { get; set; }

        public void banda()
        {
            if (sal < 11000)
            {
                ta = 9;
            }
            else if (sal > 11001 && sal < 32000)
            {
                ta = ((sal - 11000) * 0.2);
            }
            else if (sal > 320001 && sal < 150000)
            {
                ta = (((sal - 43000) * 0.4) + 6400);
            }
            else if (sal > 150000)
            {
                ta = (((sal - 150000) * 0.45) + 6400 + 47200);
            }
        }

    }
}
