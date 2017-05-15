using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1TP_SchemaWaterfall.Controllers;
using _1TP_SchemaWaterfall.Models;
using _1TP_SchemaWaterfall.Stores;

namespace _1TP_SchemaWaterfall
{
    class Program
    {
        static void Main(string[] args)
        {
            DataModelStore dms = new DataModelStore();
            UtilizadorRegisto ur = new UtilizadorRegisto();
            
            UtilizadorController utilizador = new UtilizadorController();
            Utilizador ut = new Utilizador();
            ut.Username = "jose";
            ut.Password = "xpto";
            utilizador.CriarUtilizador(ut);
            DataModel dm = new DataModel();
            
            dm.UtilizadorRegisto= new UtilizadorRegisto();
            dm.UtilizadorRegisto.UtilizadoresList = new List<Utilizador>();
            

            Console.ReadKey();
        }
    }
}
