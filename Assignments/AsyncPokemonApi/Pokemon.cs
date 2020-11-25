using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncPokemonApi
{
    public class Pokemon
    {
        public dynamic Id { get; internal set; }
        public dynamic Name { get; internal set; }
        public dynamic BackImageUri { get; internal set; }
        public dynamic FrontImageUri { get; internal set; }
        public int BaseHP { get; internal set; }
        public int ActingHP { get; internal set; }
        public int Attack { get; internal set; }
        public int Defense { get; internal set; }
        public int SpecialAttack { get; internal set; }
        public int SpecialDefense { get; internal set; }
        public int Speed { get; internal set; }

        public void ChangeName(string newName, Stopwatch sw)
        {
            // do stuffz
            Task.Delay(100 * Speed); // delay by each pokemon's unique speed
            Name = newName;
            Console.WriteLine($"Name changed to {newName} at {sw.ElapsedMilliseconds}");
        }
    }
}
