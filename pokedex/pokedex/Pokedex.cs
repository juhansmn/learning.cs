using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pokebase;

namespace pokedex
{
    class Pokedex
    {
       public List<Pokemon> pokemons = new List<Pokemon>();

        public Pokedex()
        {
            string recebePokemons = Pokebase.ListarPokemons();
            string[] pokemonsTemp = recebePokemons.Split('\n');
            
            for(int i = 0; i < pokemonsTemp.Length - 1; i++)
            {
                string[] tempAtributos = pokemonsTemp[i].Split('#');

                string tempHabilidade = Pokebase.SelecionarHabilidadesPokemon(Convert.ToInt32(tempAtributos[0]));
                string tempCategoria = Pokebase.SelecionarCategoria(Convert.ToInt32(tempAtributos[0]));
                string tempFraquezas = Pokebase.SelecionarFraquezasPokemon(Convert.ToInt32(tempAtributos[0]));

                Pokemon tempPokemon = new Pokemon(tempAtributos[0], tempAtributos[1], tempAtributos[2], tempAtributos[3], tempAtributos[4], tempHabilidade, tempFraquezas, tempCategoria);
                pokemons.Add(tempPokemon);
            }
        }

    }
}
