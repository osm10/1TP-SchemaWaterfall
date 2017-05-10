using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{
    public class InvalidAreaParametersException :Exception
    {
        public InvalidAreaParametersException() 
            : base()
        {

        }
        public InvalidAreaParametersException(double value):base(string.Format("Não pode devolver {0}.", value))
        {
            
        }
    }
}
