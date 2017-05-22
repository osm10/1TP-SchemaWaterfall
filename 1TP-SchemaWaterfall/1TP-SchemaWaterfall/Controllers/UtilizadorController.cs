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

        public static string GetPassword(string username, string password)
        {
            throw new NotImplementedException();
        }
    }

}