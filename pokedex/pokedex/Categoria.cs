using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokedex
{
    class Categoria
    {
        public string nome { get; set; }
        public string descricao { get; set; }

        public Categoria(string nome)
        {
            this.nome = nome;
            this.descricao = "Cabelo colorido";
        }

        public override string ToString()
        {
            return this.nome;
        }
    }
}
