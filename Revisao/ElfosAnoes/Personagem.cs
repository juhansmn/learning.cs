using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElfosAnoes
{
    class PersonagemTeste{
        Random aleatorio = new Random();

        static int vidaTotal = 0;
        private string _nome;
        private int _vida;
        private int _mana;
        private int _xp;

        public PersonagemTeste(string nome, int vida, int mana)
        {
            this._nome = nome;
            this._vida = vida;
            this._mana = mana;
            this._xp = 0;

            vidaTotal += vida;
        }

        public String nome
        {
            get
            {
                return this._nome;
            }
        }

        public int vida
        {
            get
            {
                return this._vida;
            }
            set
            {
                this._vida = value;
            }
        }

        public int mana
        {
            get
            {
                return this._mana;
            }
        }

        public int xp
        {
            get
            {
                return this._xp;
            }
        }

        //Método Curar e Curar(amigo)
        //Gasta toda a Mana para curar o HP. Ele cura a mesma quantidade de Mana que tiver caso não passe nada.

        public void Curar()
        {
            this._vida -= aleatorio.Next(1, 40);
        }

        public void Curar(int manaGasta)
        {
            this._mana -= manaGasta;
            this._vida += manaGasta;

            vidaTotal += manaGasta;

        }

        public void Curar(int manaGasta, PersonagemTeste aliado)
        {
            this._mana -= manaGasta;
            aliado.vida += manaGasta;

            vidaTotal += manaGasta;

        }

        public void Meditar()
        {
            int manaRecuperada = aleatorio.Next(1, 40);
            this._mana += manaRecuperada;

        }

        //Método Lutar(amigo) e Lutar()
        //Lutar retorna XP. Caso lutando com um amigo, ele retorna a quantidade perdida de HP do perdedor como XP.
        public void Lutar()
        {
            int ataques = aleatorio.Next(1, 40);
            this._vida -= ataques;
            this._xp += ataques;

            vidaTotal -= ataques;

        }

        public void Lutar(PersonagemTeste aliado)
        {
            int ataques = 0;
            if (aliado.xp > this._xp)
            {
                ataques = aleatorio.Next(this._xp / 2, this._xp);
                this._vida -= ataques;

            }
            ataques = aleatorio.Next(aliado.xp / 2, aliado.xp);
            vidaTotal -= ataques;
        }

        static public string Help(){
            return "Lute para ganhar XP\nCure para ganhar Vida\nMedite para ganhar Mana.";
        }
    }
}
