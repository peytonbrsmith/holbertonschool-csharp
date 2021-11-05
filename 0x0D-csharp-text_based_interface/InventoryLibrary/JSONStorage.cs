using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    /// <summary>
    /// JsonStorage
    /// </summary>
    public class JSONStorage
    {
        /// <summary>
        ///  Loads the inventory from a json file.
        /// </summary>
        public string jsonPath = "../storage/inventory_manager.json";
        Dictionary<string, Object> objects;


        /// <summary>
        /// All Objects
        /// </summary>
        /// <returns>the dictionary of objects</returns>
        public Dictionary<string, Object> All()
        {
            return objects;
        }

        /// <summary>
        /// Insets obj into obj dictionary
        /// </summary>
        /// <param name="obj">the obj to be added</param>
        public void New(BaseClass obj)
        {
            string key = obj.GetType().Name.ToLower() + "." + obj.Id;
            objects.Add(key, obj);
            this.Save();
            this.Load();
            Console.WriteLine("New/updated object added to JSON storage: " + key);
        }

        /// <summary>
        /// Saves the file to the jsonPath.
        /// </summary>
        public void Save()
        {
            if (!File.Exists(jsonPath))
            {
                File.Create(jsonPath);
            }
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = false,
                IgnoreNullValues = true,
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(objects, options);
            File.WriteAllText(jsonPath, json);
        }

        /// <summary>
        /// Loads the inventory from a json file.
        /// </summary>
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
                try
                {
                    objects = JsonSerializer.Deserialize<Dictionary<string, Object>>(json);
                }
                catch
                {

                }
            }
            else
            {
                var myFile = File.Create(jsonPath);
                myFile.Close();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JSONStorage"/> class.
        /// </summary>
        public JSONStorage()
        {
            objects = new Dictionary<string, Object>();
            this.Load();
        }
    }
}
