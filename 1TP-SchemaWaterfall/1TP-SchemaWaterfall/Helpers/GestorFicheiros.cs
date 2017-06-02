using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using _1TP_SchemaWaterfall.Models;
using _1TP_SchemaWaterfall.Stores;

namespace _1TP_SchemaWaterfall.Helpers
{
    public static class GestorFicheiros
    {
        public static DataModelStore CarregarDataModel()
        {
            DataModelStore dm = new DataModelStore();
            string data = string.Empty;
            if (File.Exists("data.txt"))
            {
                try
                {
                    data = File.ReadAllText("data.txt");
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Não foi possível abrir o ficheiro backup.txt.");
                    Console.WriteLine(ex.Message);
                }
               // dm.DataModel = JsonConvert.DeserializeObject<DataModel>(data);
                return dm;
            }
            return null;
        }
        public static void GravarDataModel()
        {
            string dataToSave = JsonConvert.SerializeObject(DataModelStore.Instance.DataModel);
            try
            {
                File.WriteAllText("data.txt", dataToSave);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Não foi possível criar/guardar o ficheiro. ");
                Console.WriteLine(ex.Message);
            }
        }
        public static List<Utilizador> LoadUsers()
        {
            using (StreamReader r = new StreamReader("users.txt"))
            {
                string json = r.ReadToEnd();
                List<Utilizador> users = JsonConvert.DeserializeObject<List<Utilizador>>(json);
                return users;
            }

        }

        public static void GravaUsers(List<Utilizador>users )
        {
            //open file stream
            using (StreamWriter file = new StreamWriter("users.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, users);
            }
        }

        public static List<UtilizadorRegisto> LoadUsersDados()
        {
            if (!File.Exists("utilizadordados.txt")) return null;
            using (StreamReader r = new StreamReader("utilizadordados.txt"))
            {
                string json = r.ReadToEnd();
                List<UtilizadorRegisto> users = JsonConvert.DeserializeObject<List<UtilizadorRegisto>>(json);
                return users;
            }
        }

        public static void GravaUsers(List<UtilizadorRegisto> userdados)
        {
            //open file stream
            using (StreamWriter file = new StreamWriter("utilizadoresdados.txt"))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, userdados);
            }
        }
    }
}
