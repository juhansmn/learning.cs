using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pokebase;

namespace pokedex
{
    class Tipo
    {
        public string nome { get; set; }
        public string descricao { get; set; }

        public Tipo(string nome)
        {
            this.nome = nome;
            this.descricao = "DADDY ISSUES";
        }

        public static List<Tipo> BuscarTipo(int numero)
        {
            string tempTipo = Pokebase.SelecionarTiposPokemon(numero);
            string[] t = tempTipo.Split('\n');
            List<Tipo> tipos = new List<Tipo>();

            for (int i = 0; i < t.Length - 1; i++)
            {
                Tipo tipo = new Tipo(t[i]);
                tipos.Add(tipo);
            }

            return tipos;
        }

        public static List<Tipo> BuscarFraqueza(int numero)
        {
            string tempFraqueza = Pokebase.SelecionarFraquezasPokemon(numero);
            string[] f = tempFraqueza.Split('\n');
            List<Tipo> fraquezas = new List<Tipo>();

            for (int i = 0; i < f.Length - 1; i++)
            {
                Tipo fraqueza = new Tipo(f[i]);
                fraquezas.Add(fraqueza);
            }

            return fraquezas;
        }

        public override string ToString()
        {
            return this.nome;
        }
    }
}
