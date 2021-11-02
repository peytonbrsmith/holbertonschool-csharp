using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        Dictionary<string, Object> objects;

        public Dictionary<string, Object> All()
        {
            return objects;
        }

        public void New(BaseClass obj)
        {
            string key = obj.GetType().Name + "." + obj.Id;
            objects.Add(key, obj);
            this.Save();
            this.Load();
        }

        public void Save()
        {
            string jsonPath = "storage/inventory_manager.json";

            if (!File.Exists(jsonPath))
            {
                File.Create(jsonPath);
            }

            string json = JsonSerializer.Serialize(objects);
            Console.WriteLine(json);
            File.WriteAllText(jsonPath, json);
        }

        public void Load()
        {
            string jsonPath = "storage/inventory_manager.json";
            string directory = "storage/";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (File.Exists(jsonPath))
            {
                try
                {
                    string json = File.ReadAllText(jsonPath);
                    objects = JsonSerializer.Deserialize<Dictionary<string, Object>>(json);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                File.Create(jsonPath);
            }


        }

        public JSONStorage()
        {
            objects = new Dictionary<string, Object>();
            this.Load();
        }
    }
}
