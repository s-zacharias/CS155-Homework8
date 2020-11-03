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
                            if (Charlie.Alive)
                            {
                                Console.WriteLine("Aaron missed Charlie!");
                            } else
                            {
                                Console.WriteLine("Aaron got Charlie!");
                            }
                        }
                        else if (Bob.Alive)
                        {
                            Aaron.ShootAtTarget(Bob);
                            if (Bob.Alive)
                            {
                                Console.WriteLine("Aaron missed Bob!");
                            }
                            else
                            {
                                Console.WriteLine("Aaron got Bob!");
                            }
                        }
                    }
                    if (Bob.Alive)
                    {
                        if (Charlie.Alive)
                        {
                            Bob.ShootAtTarget(Charlie);
                            if (Charlie.Alive)
                            {
                                Console.WriteLine("Bob missed Charlie!");
                            }
                            else
                            {
                                Console.WriteLine("Bob got Charlie!");
                            }
                        }
                        else if (Aaron.Alive)
                        {
                            Bob.ShootAtTarget(Aaron);
                            if (Aaron.Alive)
                            {
                                Console.WriteLine("Bob missed Aaron!");
                            }
                            else
                            {
                                Console.WriteLine("Bob got Aaron!");
                            }
                        }
                    }
                    if (Charlie.Alive)
                    {
                        if (Bob.Alive)
                        {
                            Charlie.ShootAtTarget(Bob);
                            if (Bob.Alive)
                            {
                                Console.WriteLine("Charlie missed Bob!");
                            }
                            else
                            {
                                Console.WriteLine("Charlie got Bob!");
                            }
                        }
                        else if (Aaron.Alive)
                        {
                            Charlie.ShootAtTarget(Aaron);
                            if (Aaron.Alive)
                            {
                                Console.WriteLine("Charlie missed Aaron!");
                            }
                            else
                            {
                                Console.WriteLine("Charlie got Aaron!");
                            }
                        }
                    }
                }
                if (Aaron.Alive)
                {
                    AaronWin++;
                } else if (Bob.Alive)
                {
                    BobWin++;
                } else if (Charlie.Alive)
                {
                    CharlieWin++;
                }
            }
            Console.WriteLine("Aaron won: " + AaronWin);
            Console.WriteLine("Bob won: " + BobWin);
            Console.WriteLine("Charlie won: " + CharlieWin);
        }
    }
}
