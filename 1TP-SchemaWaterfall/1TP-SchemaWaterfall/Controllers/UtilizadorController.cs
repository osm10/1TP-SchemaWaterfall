using System;
using System.Collections.Generic;
using System.Linq;
using _1TP_SchemaWaterfall.Helpers;
using _1TP_SchemaWaterfall.Models;
using _1TP_SchemaWaterfall.Stores;

namespace _1TP_SchemaWaterfall.Controllers
{
    public class UtilizadorController
    {
        public List<UtilizadorRegisto> Utilizadores;

        public UtilizadorController()
        {
            Utilizadores = DataModelStore.Instance.DataModel.UtilizadorDados;
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

        /// <summary>
        /// Método de Editar dados de um Utilizador
        /// </summary>
        /// <param name="indice">indice da lista</param>
        /// <param name="nut"> alterações feitas no utlizador</param>
        /// <returns>retorna um booleano</returns>
        public bool EditarUtilizador(int indice, UtilizadorRegisto nut)
        { 
            if (nut == null  || indice < 0 || indice >= Utilizadores.Count) return false;         
                
            Utilizadores[indice] = nut;
            GestorFicheiros.GravaUsers(Utilizadores);
            return true;
        }
        public bool RemoverUtilizador(int bidentidade)
        {
            if (Utilizadores == null) return false;
            foreach (var ut in Utilizadores)
            {
                if (ut.Bident == bidentidade)
                {
                    if(Utilizadores.Remove(ut))
                    {
                        GestorFicheiros.GravaUsers(Utilizadores);
                        return true;
                    }
                }
            }
            return false;
        }

        public List<UtilizadorRegisto> ListarUtilizadores()
        {
            if (Utilizadores.Count > 0)
            {
                return Utilizadores;
            }
            return null;
        }

        public bool ContaValida(string username, string password)
        {
            List<Utilizador> users = GestorFicheiros.LoadUsers();
            if (users.Count > 0)
            {
                foreach (var ut in users)
                {
                    if (ut.Username == username && ut.Password == password)
                    {
                        return true;
                    }
                }
            }
           
            return false;
        }
    }

}