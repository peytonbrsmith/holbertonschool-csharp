using System;

namespace InventoryLibrary
{
    public class BaseClass
    {
        private string id;
        private DateTime date_created;
        private DateTime date_updated;
        // public string id;
        // public DateTime date_created;
        // public DateTime date_updated;

        public BaseClass()
        {
            this.id = Guid.NewGuid().ToString();
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Date_created
        {
            get { return date_created; }
        }

        public DateTime Date_updated
        {
            get { return date_updated; }
            set { date_updated = value; }
        }
    }
}
