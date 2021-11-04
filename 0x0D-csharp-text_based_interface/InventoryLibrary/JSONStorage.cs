using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    public class JSONStorage
    {

        public string jsonPath = "../storage/inventory_manager.json";
        Dictionary<string, Object> objects;

        public Dictionary<string, Object> All()
        {
            return objects;
        }

        public void New(BaseClass obj)
        {
            string key = obj.GetType().Name.ToLower() + "." + obj.Id;
            objects.Add(key, obj);
            this.Save();
            this.Load();
            Console.WriteLine("New/updated object added to JSON storage: " + key);
        }

        public void Save()
        {
            if (!File.Exists(jsonPath))
            {
                File.Create(jsonPath);
            }

            string json = JsonSerializer.Serialize(objects);
            File.WriteAllText(jsonPath, json);
        }

        public void Load()
        {
            string directory = "../storage/";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (File.Exists(jsonPath))
            {
                string json = File.ReadAllText(jsonPath);
                objects = JsonSerializer.Deserialize<Dictionary<string, Object>>(json);
            }
            else
            {
                var myFile = File.Create(jsonPath);
                myFile.Close();
            }
        }

        public JSONStorage()
        {
            objects = new Dictionary<string, Object>();
            this.Load();
        }
    }
}
