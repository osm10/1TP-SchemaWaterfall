using _1TP_SchemaWaterfall.Models;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace _1TP_SchemaWaterfall.Stores
{
    public class DataModelStore
    {
        public DataModel DataModel { get; private set; }

        public DataModelStore()
        {
            if (Instance != null)
            {
                return;
            }

            string data = string.Empty;
            if (File.Exists("data.txt"))
            {
                try
                {
                    data = File.ReadAllText("data.txt");
                }
                catch (IOException e)
                {
                    Console.WriteLine("Não foi possível abrir o ficheiro backup.txt.");
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }
                DataModel = JsonConvert.DeserializeObject<DataModel>(data);
            }
            else
            {
                // Todo: Populate our database
                // Todo: Populate our database
                DataModel.UtilizadorRegisto = new UtilizadorRegisto
                {
                    UtilizadoresList = new List<Utilizador>()
                    {
                        new Utilizador() {Username = "User 1", Password = "123"},
                        new Utilizador() {Username = "User 2", Password = "321"},
                        new Utilizador() {Username = "User 3", Password = "222"},
                    }
                };
                DataModel.ProjetosList = new List<Projeto>()
                {
                    new Projeto(){Nome = "Projeto 1", User = DataModel.UtilizadorRegisto.UtilizadoresList[0]},
                    new Projeto(){Nome = "Projeto 2", User = DataModel.UtilizadorRegisto.UtilizadoresList[1]},
                };

                string dataToSave = JsonConvert.SerializeObject(DataModel);
                try
                {
                    File.WriteAllText("data.txt", dataToSave);
                }
                catch (IOException e)
                {
                    Console.WriteLine("Não foi possível criar/guardar o ficheiro. ");
                    Console.WriteLine(e.Message);
                }
            }
        }

        public static DataModelStore Instance { get; } = new DataModelStore();
    }
}
