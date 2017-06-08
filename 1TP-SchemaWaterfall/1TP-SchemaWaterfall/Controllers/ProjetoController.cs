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

        public bool CriarProjeto(Projeto p)
        {
            if (p != null)
            {
                Projetos.Add(p);
                return true;
            }
            return false;
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
    }
}
