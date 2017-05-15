
using System.Collections.Generic;

namespace _1TP_SchemaWaterfall.Models
{
    public class Subtarefa: Tarefa
    {
        public int Quantas { get; set; }
        public string Descricao { get; set; }

        public List<Subtarefa> subtarefas = new List<Subtarefa>();

    }
}
