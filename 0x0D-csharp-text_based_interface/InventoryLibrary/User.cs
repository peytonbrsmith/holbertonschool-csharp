using System;

namespace InventoryLibrary
{
    public class User : BaseClass
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public User(string name)
        {
            Name = name;
        }
    }
}
