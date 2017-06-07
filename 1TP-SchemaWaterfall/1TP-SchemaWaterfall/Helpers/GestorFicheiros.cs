using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using _1TP_SchemaWaterfall.Models;

namespace _1TP_SchemaWaterfall.Helpers
{
    public static class GestorFicheiros
    {
        private static string _usersFile = "users.txt";
        private static string _utilizadoresdadosFile = "utilizadoresdados.txt";
        private static string _projetosFile = "projetos.txt";
        private static string _tarefasFile = "tarefas.txt";

        //public static DataModelStore CarregarDataModel()
        //{
        //    DataModelStore dm = new DataModelStore();
        //    string data = string.Empty;
        //    if (File.Exists("data.txt"))
        //    {
        //        try
        //        {
        //            data = File.ReadAllText("data.txt");
        //        }
        //        catch (IOException ex)
        //        {
        //            Console.WriteLine("Não foi possível abrir o ficheiro backup.txt.");
        //            Console.WriteLine(ex.Message);
        //        }
        //       // dm.DataModel = JsonConvert.DeserializeObject<DataModel>(data);
        //        return dm;
        //    }
        //    return null;
        //}
        //public static void GravarDataModel()
        //{
        //    string dataToSave = JsonConvert.SerializeObject(DataModelStore.Instance.DataModel);
        //    try
        //    {
        //        File.WriteAllText("data.txt", dataToSave);
        //    }
        //    catch (IOException ex)
        //    {
        //        Console.WriteLine("Não foi possível criar/guardar o ficheiro. ");
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        public static List<Utilizador> LoadUsers()
        {
            using (StreamReader r = new StreamReader(_usersFile))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Utilizador>>(json);
            }

        }

        public static void GravaUsers(List<Utilizador>users )
        {
            using (StreamWriter file = new StreamWriter(_usersFile))
            {
                //serializa o objecto directamente para o ficheiro em stream
                new JsonSerializer().Serialize(file, users);
            }
        }

        public static List<UtilizadorRegisto> LoadUsersDados()
        {
            if (!File.Exists(_utilizadoresdadosFile)) return null;

            using (StreamReader r = new StreamReader(_utilizadoresdadosFile))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<UtilizadorRegisto>>(json);
            }
        }

        public static void GravaUsers(List<UtilizadorRegisto> userdados)
        {
            using (StreamWriter file = new StreamWriter(_utilizadoresdadosFile))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serializa o objecto directamente para o ficheiro em stream
                serializer.Serialize(file, userdados);
            }
        }

        public static List<Projeto> LoadProjetos()
        {
            if (!File.Exists(_projetosFile)) return null;
            using (StreamReader r = new StreamReader(_projetosFile))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Projeto>>(json);
            }
        }

        public static void GravaProjetos(List<Projeto> projetos)
        {
            using (StreamWriter file = new StreamWriter(_projetosFile))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serializa o objecto directamente para o ficheiro em stream
                serializer.Serialize(file, projetos);
            }
        }

        public static List<Tarefa> LoadTarefas()
        {
            if (!File.Exists(_tarefasFile)) return null;
            using (StreamReader r = new StreamReader(_tarefasFile))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Tarefa>>(json);
            }
        }

        public static void GravaTarefas(List<Tarefa> tarefas)
        {
            using (StreamWriter file = new StreamWriter(_tarefasFile))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serializa o objecto directamente para o ficheiro em stream
                serializer.Serialize(file, tarefas);
            }
        }

        /*
        public static List<T> Load<T>(string filepath)
        {
            if (!File.Exists(filepath)) return null;
            using (StreamReader r = new StreamReader(filepath))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<T>>(json);
            }
        }

        public static void Grava<T>(List<T> elems, string filepath)
        {
            using (StreamWriter file = new StreamWriter(filepath))
            {
                //serializa o objecto directamente para o ficheiro em stream
                new JsonSerializer().Serialize(file, filepath);
            }
        }
        */
    }
}
