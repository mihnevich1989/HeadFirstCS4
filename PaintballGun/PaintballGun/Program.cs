﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintballGun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ReadInt(int lastUsedValue, string prompt)
            {
                Console.Write($"{prompt} [{lastUsedValue}]: ");
                string line = Console.ReadLine();

                if (int.TryParse(line, out int value))
                {
                    Console.WriteLine($" using value {value}");
                    return value;
                }
                else
                {
                    Console.WriteLine($" using default value {lastUsedValue}");
                    return lastUsedValue;
                }

            }

            int numberOfBalls = ReadInt(20, "Number of balls");
            int magazineSize = ReadInt(16, "Magazine size");

            Console.Write($"Loaded [false]: ");
            bool.TryParse(Console.ReadLine(), out bool isLoaded);

            PaintballGun gun = new PaintballGun(numberOfBalls, magazineSize, isLoaded);

            while (true)
            {
                Console.WriteLine($"{gun.Balls} balls, {gun.BallsLoaded} loaded");
                if (gun.IsEmpty()) Console.WriteLine("WARNING: You're gun out of ammo");
                Console.WriteLine("Space to shoot, r to reload, + to add ammo, q to quit");
                char key = Console.ReadKey().KeyChar;
                if (key == ' ') Console.WriteLine($"Shooting returned {gun.Shoot()}");
                else if (key == 'r') gun.Reload();
                else if (key == '+') gun.Balls += gun.MagazineSize;
                else if (key == 'q') return;
            }
        }
    }
}
