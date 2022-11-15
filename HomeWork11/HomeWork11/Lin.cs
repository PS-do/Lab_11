using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11
{
    internal class Lin //linear equation 
    {
        double k;
        double b;
        public Lin(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public double Root() 
            { return (-b / k); }
    }
}
