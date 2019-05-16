using System.Collections.Generic;
using System;

namespace pokedex
{
    class Pokemon
    {
        public string numero { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string peso { get; set; }
        public string altura { get; set; }
        public string habilidade { get; set; }
        public Categoria categoria { get; set; }

        public List<Tipo> tipos = new List<Tipo>();
        public List<Tipo> fraquezas = new List<Tipo>();

        public Pokemon(string numero, string nome, string descricao, string peso, string altura, string habilidade, string fraqueza, string categoria)
        {
            this.numero = numero;
            this.nome = nome;
            this.descricao = descricao;
            this.peso = peso;
            this.altura = altura;
            this.habilidade = habilidade;

            this.tipos = Tipo.BuscarTipo(Convert.ToInt32(this.numero));
            this.fraquezas = Tipo.BuscarTipo(Convert.ToInt32(this.numero));

            this.categoria = new Categoria(categoria);
        }
    }
}
