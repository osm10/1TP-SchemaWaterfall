﻿using System;
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

        public Tarefa Tarefa { get; set; }

        public Projeto()
        {
            Tarefa = new Tarefa();
            User = new Utilizador();
        }
    }
    
}
