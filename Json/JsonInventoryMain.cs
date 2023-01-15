using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Json
{
    internal class JsonInventoryMain
    {
        InventoryModel model = new InventoryModel();

        List<InventoryModel> list = new List<InventoryModel>();

        public void Convert(string jFilePath)
        {
            using (StreamReader file = new StreamReader(jFilePath))
            {
                var json = file.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<InventoryModel>>(json);
                Console.WriteLine("Items Price Weight TotalValue");
                foreach (var objects in items)
                {
                    double value = objects.price * objects.weight;
                    Console.WriteLine(objects.name + " -> " + objects.price + " -> " + objects.weight + " -> " + value);
                }

            }
        }
    }
}
