using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1TP_SchemaWaterfall.Models
{
    public class Projeto
    {
        public string Nome { get; set; }
        public Utilizador User { get; set; }

        public DateTime Datainicio { get; set; }

        public List<Tarefa> Tarefas { get; set; }

        public Projeto()
        {
            Tarefas = new List<Tarefa>();
            User = new Utilizador();
        }
    }
    
}
