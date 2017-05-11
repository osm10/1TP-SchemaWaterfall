using System;
using System.Collections.Generic;
using System.Linq;
using _1TP_SchemaWaterfall.Models;
using _1TP_SchemaWaterfall.Stores;

namespace _1TP_SchemaWaterfall.Controllers
{
    public class UtilizadorController
    {
        private List<Utilizador> _utilizadores = new List<Utilizador>();
        public UtilizadorController()
        {
            foreach (Projeto project in DataModelStore.Instance.DataModel.ProjetosList)
            {
                Console.WriteLine(project.Nome);
            }
            DataModelStore.Instance.DataModel.UtilizadorRegisto.UtilizadoresList.Add(new Utilizador() { Username = "USer 4", Password = "asdfadsf" });
            Console.ReadLine();
        }

        public void CriarUtilizador(Utilizador ut)
        {
            _utilizadores.Add(ut);
        }

        public bool RemoverUtilizador(string username)
        {
            var utilizador = _utilizadores.FirstOrDefault(u => u.Username == username);
            if (utilizador == null) return false;
            return _utilizadores.Remove(utilizador);
        }

        public void ListarUtilizadores()
        {
            if (_utilizadores.Count > 0)
            {
                foreach (var uti in _utilizadores)
                {
                    Console.WriteLine("Username " + uti.Username);
                }
            }
            else Console.WriteLine("Sem utilizadores!");
        }
    }

}