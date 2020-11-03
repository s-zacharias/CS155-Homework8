using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create duelists
            Duelist Aaron = new Duelist() { Name = "Aaron", ShootingAccuracy = (1.0 / 3), Alive = true };
            Duelist Bob = new Duelist() { Name = "Bob", ShootingAccuracy = 0.5, Alive = true };
            Duelist Charlie = new Duelist() { Name = "Charlie", ShootingAccuracy = 0.995, Alive = true };

            // keep track of winners 
            int AaronWin = 0;
            int BobWin = 0;
            int CharlieWin = 0;

            // number of duels
            int duels = 10000;

            for (int i = 0; i < duels; i++)
            {
                while ((Aaron.Alive && Bob.Alive) || (Aaron.Alive && Charlie.Alive)
                || (Bob.Alive && Charlie.Alive))
                {
                    if (Aaron.Alive)
                    {
                        if (Charlie.Alive)
                        {
                            Aaron.ShootAtTarget(Charlie);
                        }
                        else if (Bob.Alive)
                        {
                            Aaron.ShootAtTarget(Bob);
                        }
                    }
                    if (Bob.Alive)
                    {
                        if (Charlie.Alive)
                        {
                            Bob.ShootAtTarget(Charlie);
                        }
                        else if (Aaron.Alive)
                        {
                            Bob.ShootAtTarget(Aaron);
                        }
                    }
                    if (Charlie.Alive)
                    {
                        if (Bob.Alive)
                        {
                            Charlie.ShootAtTarget(Bob);
                        }
                        else if (Aaron.Alive)
                        {
                            Charlie.ShootAtTarget(Aaron);
                        }
                    }
                }
                if (Aaron.Alive)
                {
                    AaronWin++;
                }
                else if (Bob.Alive)
                {
                    BobWin++;
                }
                else if (Charlie.Alive)
                {
                    CharlieWin++;
                }
                Aaron.Alive = true;
                Bob.Alive = true;
                Charlie.Alive = true;
            }

            Console.WriteLine("Aaron won: " + AaronWin + " out of " + duels + " duels" +
                "\n or " + (double)AaronWin/duels * 100 + "% of duels");
            Console.WriteLine("Bob won: " + BobWin + " out of " + duels + " duels" +
                "\n or " + (double)BobWin / duels * 100 + "% of duels");
            Console.WriteLine("Charlie won: " + CharlieWin + " out of " + duels + " duels" +
                "\n or " + (double)CharlieWin / duels * 100 + "% of duels");
        }
    }
}
