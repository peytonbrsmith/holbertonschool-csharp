using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Inventory Class
    /// </summary>
    public class Inventory : BaseClass
    {

        private string user_id;
        private string item_id;
        private int quantity;

        /// <summary>
        /// Gets or sets User_id
        /// </summary>
        public string User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }

        /// <summary>
        /// Gets or sets Item_id
        ///  </summary>
        public string Item_id
        {
            get { return item_id; }
            set { item_id = value; }
        }

        /// <summary>
        /// gets or sets quantity
        /// </summary>
        public int Quantity
        {
            get { return quantity; }
            set {
                if (value < 0)
                {
                    quantity = 0;
                }
                else
                {
                    quantity = value;
                }
                }
        }

        /// <summary>
        /// Constructor for inventory object
        /// </summary>
        /// <param name="user_id">ID of user</param>
        /// <param name="item_id">ID of item</param>
        /// <param name="quantity">Quantity</param>
        public Inventory(string user_id, string item_id, int quantity = 1)
        {
            User_id = user_id;
            Item_id = item_id;
            Quantity = quantity;
        }
    }
}
