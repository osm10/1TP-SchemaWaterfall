using System.Collections.Generic;

using _1TP_SchemaWaterfall.Models;

namespace _1TP_SchemaWaterfall.Controllers
{
    public class TarefaController
    {
        List<Subtarefa> subtarefas = new List<Subtarefa>();
        public bool AdicionarSubtarefa(Tarefa ta, Subtarefa subt)
        {
            if (ta != null && subt != null)
            {               
                subtarefas.Add(subt);
            }
            return false;
        }
        public bool EditarSubtarefa(Tarefa ta, Subtarefa subt)
        {
            if (ta != null && subt != null)
            {
                subtarefas.Add(subt);
            }
            return false;
        }
        public bool RemoverSubtarefa(Tarefa ta, Subtarefa subt)
        {
            if (ta != null && subt != null)
            {
                subtarefas.Add(subt);
            }
            return false;
        }
    }
}
