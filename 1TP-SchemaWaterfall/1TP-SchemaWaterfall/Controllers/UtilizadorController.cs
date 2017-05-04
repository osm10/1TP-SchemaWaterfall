using System;
using _1TP_SchemaWaterfall.Models;
using _1TP_SchemaWaterfall.Stores;

namespace _1TP_SchemaWaterfall.Controllers
{
    public class UtilizadorController
    {
        public UtilizadorController()
        {
            foreach (Projeto project in DataModelStore.Instance.DataModel.ProjetosList)
            {
                Console.WriteLine(project.Nome);
            }
            DataModelStore.Instance.DataModel.UtilizadorRegisto.UtilizadoresList.Add(new Utilizador() { Username = "USer 4", Password = "asdfadsf" });
            Console.ReadLine();
        }
    }
}
