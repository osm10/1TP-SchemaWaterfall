using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1TP_SchemaWaterfall.Models
{
    public class DataModel
    {
        public List<UtilizadorRegisto> UtilizadorRegisto { get; set; }
        public List<Utilizador> UtilizadorList { get; set; }
        //public List<Projeto> ProjetosList { get; set; }
        public DataModel()
        {
            UtilizadorList = new List<Utilizador>();
            UtilizadorRegisto = new List<UtilizadorRegisto>();
            //ProjetosList = new List<Projeto>();
        }

        /*public DataModel(List<Utilizador> listaUtilizadors)
        {
            UtilizadorList = new List<Utilizador>(listaUtilizadors);
        }*/
    }
}
