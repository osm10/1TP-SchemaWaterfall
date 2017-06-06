using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1TP_SchemaWaterfall.Models
{
    public class DataModel
    {
        public List<UtilizadorRegisto> UtilizadorDados { get; set; }
        public List<Utilizador> UtilizadorList { get; set; }
        public List<Projeto> ProjetosList { get; set; }
        public DataModel()
        {
            UtilizadorList = new List<Utilizador>();
            UtilizadorDados = new List<UtilizadorRegisto>();
            ProjetosList = new List<Projeto>();
        }

    }
}
