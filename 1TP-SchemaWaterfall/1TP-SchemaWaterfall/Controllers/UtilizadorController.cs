using System;
using System.Collections.Generic;
using System.Linq;
using _1TP_SchemaWaterfall.Models;
using _1TP_SchemaWaterfall.Stores;

namespace _1TP_SchemaWaterfall.Controllers
{
    public class UtilizadorController
    {
        private List<UtilizadorRegisto> _utilizadores = new List<UtilizadorRegisto>();
        public UtilizadorController()
        {
            
            foreach (Projeto project in DataModelStore.Instance.DataModel.ProjetosList)
            {
                Console.WriteLine(project.Nome);
            }
            //DataModelStore.Instance.DataModel.UtilizadorRegisto.UtilizadoresList.Add(new Utilizador() { Username = "USer 4", Password = "asdfadsf" });
            Console.ReadLine();
        }

        public bool RegistarUtilizador(UtilizadorRegisto ur)
        {
            if (ur != null)
            {
                _utilizadores.Add(ur);
                return true;
            }
            return false;
        }

        public bool RemoverUtilizador(int bidentidade)
        {
            var utilizador = _utilizadores.FirstOrDefault(u => u.Bident == bidentidade);
            if (utilizador == null) return false;
            return _utilizadores.Remove(utilizador);
        }

        public void ListarUtilizadores()
        {
            if (_utilizadores.Count > 0)
            {
                foreach (var uti in _utilizadores)
                {
                    Console.WriteLine("Nome " + uti.Nome + " B.I: " +uti.Bident+" Username: "+uti.Utilizador.Username+" Password: ");
                }
            }
            else Console.WriteLine("Sem utilizadores!");
        }
    }

}