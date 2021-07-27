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
            health = value;
        }
    }
}
