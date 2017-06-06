using _1TP_SchemaWaterfall.Models;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using _1TP_SchemaWaterfall.Helpers;


namespace _1TP_SchemaWaterfall.Stores
{
    public class DataModelStore
    {
        public DataModel DataModel { get; private set; }
        //public List<Utilizador> UserList { get; private set; }
        public static DataModelStore Instance { get; } = new DataModelStore();
        public DataModelStore()
        {
            if (Instance != null)
            {
                return;
            }
            DataModel = new DataModel
            {
                UtilizadorList = GestorFicheiros.LoadUsers(),
                UtilizadorDados = GestorFicheiros.LoadUsersDados(),
                ProjetosList = GestorFicheiros.LoadProjetos()
            };
            
        }
      
    }
}
