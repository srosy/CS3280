using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RestSharp;
using System;
using System.Diagnostics;
using System.Dynamic;
using System.Threading.Tasks;

namespace AsyncPokemonApi
{
    public class PokemonApi : IPokemonApi
    {
        private readonly string BASE_URL;

        public PokemonApi()
        {
            BASE_URL = "https://pokeapi.co/api/v2/pokemon/";
        }

        public Pokemon GetPokemonByName(string name, Stopwatch sw)
        {
            var client = new RestClient($"{BASE_URL}{name.ToLower()}");
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request); // sequential

            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(response.Content, new ExpandoObjectConverter());

            var pokemon = MarshalPokemonData(obj);
            Console.WriteLine($"Generated {pokemon.Name} at {sw.ElapsedMilliseconds}");

            return pokemon;
        }

        public async Task<Pokemon> GetPokemonByNameAsync(string name, Stopwatch sw)
        {
            var client = new RestClient($"{BASE_URL}{name.ToLower()}");
            var request = new RestRequest(Method.GET);

            IRestResponse response = await client.ExecuteAsync(request); // async

            dynamic obj = JsonConvert.DeserializeObject<ExpandoObject>(response.Content, new ExpandoObjectConverter());

            var pokemon = MarshalPokemonData(obj);
            Console.WriteLine($"Generated {pokemon.Name} at {sw.ElapsedMilliseconds}");

            return pokemon;
        }

        private Pokemon MarshalPokemonData(dynamic obj)
        {
            // create Pokemon from PokeApi.Pokemon
            var pokemon = new Pokemon();
            pokemon.Id = Convert.ToInt32(obj.id);
            pokemon.Name = obj.name.ToString();
            pokemon.BackImageUri = obj.sprites.back_default.ToString();
            pokemon.FrontImageUri = obj.sprites.front_default.ToString();

            //0 hp, 1 attack, 2 defense, 3 special attack, 4 special defense, 5 speed
            pokemon.BaseHP = (int)obj.stats[0].base_stat * 5;
            pokemon.ActingHP = pokemon.BaseHP;
            pokemon.Attack = (int)obj.stats[1].base_stat;
            pokemon.Defense = (int)obj.stats[2].base_stat;
            pokemon.SpecialAttack = (int)obj.stats[3].base_stat;
            pokemon.SpecialDefense = (int)obj.stats[4].base_stat;
            pokemon.Speed = (int)obj.stats[5].base_stat;

            return pokemon;
        }
    }
}
