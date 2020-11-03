using System;
namespace Project1
{
    public class Duelist
    {
        // instance variables
        String name;
        double shootingAccuracy;
        bool alive;

        // Properties
        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public double ShootingAccuracy
        {
            get
            {
                return shootingAccuracy;
            }
            set
            {
                shootingAccuracy = value;
            }
        }

        public bool Alive
        {
            get
            {
                return alive;
            }
            set
            {
                alive = value;
            }
        }

        // method
        public void ShootAtTarget(Duelist target)
        {
            Random rnd = new Random();
            
            if (target.Alive == true)
            {
                double random = rnd.NextDouble();
                if (random < (this.shootingAccuracy))
                {
                    target.Alive = false;
                }
            }
        }
    }
}
