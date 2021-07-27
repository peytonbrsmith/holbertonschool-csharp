using System;

namespace Enemies
{
    /// <summary>
    /// Zombie Class
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// HEALTH
        /// </summary>
        private int health;


        /// <summary>
        /// ZOMBIE CONSTRUCTOR
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Gets and sets name of zombie
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string name = "(No name)";

        /// <summary>
        /// Constructor with health value set
        /// </summary>
        /// <param name="value"></param>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
        


        /// <summary>
        /// Gets health of zombie
        /// </summary>
        /// <returns> health value </returns>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>
        /// Overrides string format of zombie
        /// </summary>
        /// <returns>formatted string</returns>
        public override string ToString() {
            return ($"Zombie Name: {Name} / Total Health: {GetHealth()}");
        }
    }
}

