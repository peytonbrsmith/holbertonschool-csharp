using System;
using System.Collections.Generic;
using System.Text.Json;

namespace InventoryLibrary
{
    public class Item : BaseClass
    {
        private string name;
        private string description;
        private float price;
        private List<string> tags;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public float Price
        {
            get { return price; }
            set {
                value = float.Parse(value.ToString("0.00"));
                price = value;
                }
        }

        public List<string> Tags
        {
            get { return tags; }
            set { tags = value; }
        }

        public Item(string name = null, string description = null, float price = 0.0f, List<string> tags = null)
        {
            Name = name;
            if (description != "")
            {
                Description = description;
            }
            if (price > 0.0f)
                Price = price;
            if (tags != null && tags.Count > 0 && tags[0] != "")
                Tags = tags;
        }
    }
}
