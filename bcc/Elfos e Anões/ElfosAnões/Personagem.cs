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

        public Personagem(String name, int baseVida, int baseMana)
        {
            this.name = name;
            this.vida = aleatorio.Next(baseVida, 100);
            this.mana = aleatorio.Next(baseMana, 100);
        }

        public string Lutar()
        {
            if (Morreu())
                return "Ele está morto!";

            this.vida -= aleatorio.Next(30);
            this.mana -= aleatorio.Next(30);

            if (Morreu())
                return "Ele morreu!";

            return "Ele está vivo!";
        }

        public string Curar() {
            if (Morreu())
                return "Não é possível curar alguém morto.";

            int gasto = aleatorio.Next(10, 30);
            this.mana -= gasto;

            this.vida = aleatorio.Next(30);

            return gasto.ToString();
        }

        public bool Morreu()
        {
            if (this.vida <= 0) {
                this.vida = 0;
                this.mana = 0;
                return true;
            }

            return false;
        }

    }
}
