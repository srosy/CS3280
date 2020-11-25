using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncPokemonApi
{
    class Program
    {
        /// <summary>
        /// Example of different practices (Sequential, Async, and Parallel) in consuming an api and updating object properties.
        /// </summary>
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            var api = new PokemonApi();

            var pokemonNames = new List<string>()
            {
                "Charizard", "Raichu", "Jolteon", "Crobat", "Houndoom", "Articuno"
            };

            // sequential
            sw.Start();
            pokemonNames.ForEach(name =>
            {
                var pokemon = api.GetPokemonByName(name, sw);
                pokemon.ChangeName($"ChangedNameFrom-{pokemon.Name}", sw);
            });
            sw.Stop();
            Console.WriteLine($"Total elapsed time for SEQUENTIAL (normal): {sw.ElapsedMilliseconds}ms\n");

            Thread.Sleep(500);

            // async seperate some tasks onto threads, but keep track of them for some quasi sequential behavior
            sw.Reset();
            var tasks = new List<Task>();
            sw.Start();
            pokemonNames.ForEach(name =>
            {
                tasks.Add(Task.Run(async () => await api.GetPokemonByNameAsync(name, sw))
                    .ContinueWith(t => t.Result.ChangeName($"ChangedNameFrom-{t.Result.Name}", sw)));
            });
            Task.WhenAll(tasks).ContinueWith(t =>
            {
                sw.Stop();
                Console.WriteLine($"Total elapsed time for ASYNCHRONOUS (faster): {sw.ElapsedMilliseconds}ms\n");
            });

            Thread.Sleep(500);

            // parallel (fire all tasks and forget) just get them done as quickly as possible.
            // separates to all available threads; can specify num threads if needed.
            // if handling num threads allowed to execute, consider adding threadlock
            sw.Reset();
            sw.Start();
            pokemonNames.ForEach(async name =>
            {
                var pokemon = await api.GetPokemonByNameAsync(name, sw);
                await Task.Run(() => pokemon.ChangeName($"ChangedNameFrom-{pokemon.Name}", sw));
            });
            sw.Stop();
            Thread.Sleep(200); // async is too fast, make the UI thread wait to print result haha
            Console.WriteLine($"Total elapsed time for PARALLEL (fastest): {sw.ElapsedMilliseconds}ms\n");

            Console.ReadLine();
        }
    }
}
