using System;
using System.Collections.Generic;
using System.Linq;
using _1TP_SchemaWaterfall.Models;
using _1TP_SchemaWaterfall.Stores;

namespace _1TP_SchemaWaterfall.Controllers
{
    public class UtilizadorController
    {
        public List<UtilizadorRegisto> Utilizadores { get; set; }

        public UtilizadorController()
        {
            Utilizadores = new List<UtilizadorRegisto>();
        }

        public bool RegistarUtilizador(UtilizadorRegisto ur)
        {
            if (ur != null)
            {
                Utilizadores.Add(ur);
                return true;
            }
            return false;
        }

        public bool RemoverUtilizador(int bidentidade)
        {
            var utilizador = Utilizadores.FirstOrDefault(u => u.Bident == bidentidade);
            if (utilizador == null) return false;
            return Utilizadores.Remove(utilizador);
        }

        public void ListarUtilizadores()
        {
            if (Utilizadores.Count > 0)
            {
                foreach (var uti in Utilizadores)
                {
                    Console.WriteLine("Nome " + uti.Nome + " B.I: " +uti.Bident+" Username: "+uti.Utilizador.Username+" Password: ");
                }
            }
            else Console.WriteLine("Sem utilizadores!");
        }

        public bool ContaValida(string username, string password)
        {
            if (Utilizadores.Count > 0)
            {
                foreach (var ut in Utilizadores)
                {
                    if (ut.Utilizador.Username == username && ut.Utilizador.Password == password)
                    {
                        return true;
                    }
                }
            }
           
            return false;
        }
    }

}