using System.Collections.Generic;
using _1TP_SchemaWaterfall.Helpers;
using _1TP_SchemaWaterfall.Models;
using _1TP_SchemaWaterfall.Stores;

namespace _1TP_SchemaWaterfall.Controllers
{
    public class ProjetoController
    {
        public List<Projeto> Projetos;

        public ProjetoController()
        {
            Projetos = DataModelStore.Instance.DataModel.ProjetosList;
        }

        /// <summary>
        /// Método para editar projetos
        /// </summary>
        /// <param name="indice"></param>
        /// <param name="pro"></param>
        /// <returns></returns>
        public bool EditarProjetos(int indice, Projeto pro)
        {
            if (pro == null || indice < 0 || indice >= Projetos.Count) return false;

            Projetos[indice] = pro;
            GestorFicheiros.GravaProjetos(Projetos);
            return true;
        }
        public bool RemoverProjeto(Projeto p)
        {
            if (Projetos == null) return false;
           
            foreach (var pro in Projetos)
            {
                if (pro == p)
                {
                    if (Projetos.Remove(p))
                    {
                        GestorFicheiros.GravaProjetos(Projetos);
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CriarProjeto(Projeto p)
        {
            if (p != null)
            {
                Projetos.Add(p);
                return true;
            }
            return false;
        }
    }
}
