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
        public int health;
        /// <summary>
        /// ZOMBIE CONSTRUCTOR
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
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
    }
}
