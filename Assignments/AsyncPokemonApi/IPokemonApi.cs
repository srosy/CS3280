using System.Diagnostics;
using System.Threading.Tasks;

namespace AsyncPokemonApi
{
    public interface IPokemonApi
    {
        // sequential method
        Pokemon GetPokemonByName(string name, Stopwatch sw);

        // async method
        Task<Pokemon> GetPokemonByNameAsync(string name, Stopwatch sw);
    }
}
