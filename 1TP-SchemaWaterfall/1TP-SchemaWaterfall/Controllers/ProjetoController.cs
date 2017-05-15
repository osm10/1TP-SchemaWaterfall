using System.Collections.Generic;
using _1TP_SchemaWaterfall.Models;

namespace _1TP_SchemaWaterfall.Controllers
{
    public class ProjetoController
    {
        public List<Projeto> Projetos = new List<Projeto>();

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
            if (Projetos.Count > 0)
            {
                foreach (var pro in Projetos)
                {
                    if (pro == p)
                    {
                        Projetos.Remove(p);
                    }
                }
            }
            return false;
        }
    }
}
