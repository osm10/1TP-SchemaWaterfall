using System;
using System.Collections.Generic;
using _1TP_SchemaWaterfall.Controllers;
using _1TP_SchemaWaterfall.Models;

namespace _1TP_SchemaWaterfall
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataModelStore dms = new DataModelStore();
            Utilizador ut = new Utilizador();
            ut.Username = "jose";
            ut.Password = "xpto";
            UtilizadorController uc = new UtilizadorController();
            UtilizadorRegisto ur = new UtilizadorRegisto() {Nome = "Marcos", Bident = 123456789, Utilizador = ut};
            Console.WriteLine(uc.RegistarUtilizador(ur));
                        
            //utilizador.RegistarUtilizador(ur);
            DataModel dm = new DataModel();
            Projeto po = new Projeto();
            po.Nome = "Soft";
            po.User = ut;
            po.Tarefas = new List<Tarefa>();
            Subtarefa subtarefa = new Subtarefa();
            subtarefa.subtarefas = new List<Subtarefa>();
            subtarefa.Quantas = 4;
            subtarefa.Descricao = "teste";
            subtarefa.Nome = "Recolha de requisitos";
            
            //dm.UtilizadorRegisto= new UtilizadorRegisto();
            //dm.UtilizadorRegisto.UtilizadoresList = new List<Utilizador>();
            

            Console.ReadKey();
        }
    }
}
