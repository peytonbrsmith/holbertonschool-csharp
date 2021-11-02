using System;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        private string user_id;
        private string item_id;
        private int quantity;

        public string User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }

        public string Item_id
        {
            get { return item_id; }
            set { item_id = value; }
        }

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

        public Inventory(string user_id, string item_id, int quantity = 1)
        {
            User_id = user_id;
            Item_id = item_id;
            Quantity = quantity;
        }
    }
}
