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
        public static void CarregarDataModel()
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
                dm.DataModel = JsonConvert.DeserializeObject<DataModel>(data);
            }
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
    }
}
