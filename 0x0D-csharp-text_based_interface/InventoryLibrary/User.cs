using System;

namespace InventoryLibrary
{
    /// <summary>
    /// User class
    /// </summary>
    public class User : BaseClass
    {
        private string name;

        /// <summary>
        /// User name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        ///  User constructor
        /// </summary>
        /// <param name="name">Name of user</param>
        public User(string name)
        {
            Name = name;
        }
    }
}
