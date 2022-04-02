using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Base class
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// Base Class
        /// </summary>
        private string id;
        private DateTime date_created;
        private DateTime date_updated;
        // public string id;
        // public DateTime date_created;
        // public DateTime date_updated;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseClass"/> class.
        ///  </summary>
        public BaseClass()
        {
            this.id = Guid.NewGuid().ToString();
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
        }

        /// <summary>
        ///    Gets or sets the identifier.
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        ///   Sets the date created.
        /// </summary>
        public DateTime Date_created
        {
            get { return date_created; }
        }

        /// <summary>
        ///   Gets the date updated.
        /// </summary>
        public DateTime Date_updated
        {
            get { return date_updated; }
            set { date_updated = value; }
        }
    }
}
