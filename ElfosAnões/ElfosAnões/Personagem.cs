using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElfosAnões
{
    class Personagem
    {
        Random aleatorio = new Random();

        private String name;
        public int vida { get; set; }
        public int mana { get; set; }

        public Personagem(String name)
        {
            this.name = name;
            this.vida = aleatorio.Next(10, 100);
            this.mana = aleatorio.Next(10, 100);
        }

        public string Lutar()
        {
            this.vida -= aleatorio.Next(30);
            this.mana -= aleatorio.Next(20);

            if (Morreu(vida))
                return "Ele morreu!";
            return "Ele está vivo!";
        }

        public bool Morreu(int vida)
        {
            if (vida == 0)
                return true;
            return false;
        }

    }
}
