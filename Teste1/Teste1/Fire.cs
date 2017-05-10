using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{
    public abstract class Fire
    {
        public abstract Incendio HighestFire(Incendio[] arr);
        public abstract int HowManyFires(DateTime d, string regiao);
        public bool BurnedArea(double width, double height, out double area)
        {
            area = width*height;

            if (area == 0)
            {
                throw new InvalidAreaParametersException(area);
            }
            return true;
        }
    }
}
