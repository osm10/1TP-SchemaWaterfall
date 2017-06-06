using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1TP_SchemaWaterfall.Models
{
    public class Tarefa
    {
        public DateTime Datainicio { get; set; }

        public DateTime Datafinal { get; set; }

        public TarefaTipo Tipo { get; set; }
    }

    public enum TarefaTipo 
    {
        Unstart,
        Analysis,
        Designing,
        Coding,
        Testing,
        Implementation,
        Maintenance
    }


}
