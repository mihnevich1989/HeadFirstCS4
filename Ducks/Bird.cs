﻿namespace Ducks
{
    internal class Bird
    {
        public string? Name { get; set; }
        public virtual void Fly(string destination)
        {
            Console.WriteLine($"{this} is flying to {destination}");
        }

        public override string ToString()
        {
            return $"A bird named {Name}";
        }

        public static void FlyAway(List<Bird> flock, string destionation)
        {
            foreach (Bird bird in flock)
            {
                bird.Fly(destionation);
            }
        }

    }
}
