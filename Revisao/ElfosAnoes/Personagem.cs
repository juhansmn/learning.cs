using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElfosAnoes
{
    class PersonagemTeste{
        Random aleatorio = new Random();

        public static int vidaTotal = 0;
        private string _nome;
        private int _vida;
        private int _mana;
        private int _xp = 0;

        public PersonagemTeste(string nome, int vida, int mana)
        {
            this._nome = nome;
            this._vida = vida;
            this._mana = mana;

            vidaTotal += vida;
        }
        public PersonagemTeste(string nome) {
            this._vida = 100;
            this._mana = 100;

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

        public string Curar()
        {
            int vidaRecuperada = aleatorio.Next(1, 40);
            RecuperarVida(vidaRecuperada);
            PerderMana(vidaRecuperada);

            return vidaRecuperada.ToString();
        }

        public string Curar(int vidaRecuperada)
        {
            PerderMana(vidaRecuperada);
            RecuperarVida(vidaRecuperada);

            return vidaRecuperada.ToString();
        }

        public string Curar(int vidaRecuperada, PersonagemTeste aliado)
        {
            PerderMana(vidaRecuperada);
            aliado.RecuperarVida(vidaRecuperada);

            return vidaRecuperada.ToString();
        }

        public string Meditar()
        {
            int manaRecuperada = aleatorio.Next(1, 40);
            RecuperarMana(manaRecuperada);

            return manaRecuperada.ToString();
        }

        //Método Lutar(amigo) e Lutar()
        //Lutar retorna XP. Caso lutando com um amigo, ele retorna a quantidade perdida de HP do perdedor como XP.
        public string Lutar()
        {
            int ataques = aleatorio.Next(1, 40);
            PerderVida(ataques);
            DistribuirExp(ataques);

            return ataques.ToString();
        }

        public string Lutar(PersonagemTeste aliado)
        {
            int ataques;
            if (aliado.xp > this._xp)
            {
                ataques = aleatorio.Next(this.vida / 2, this.vida);
                aliado.DistribuirExp(ataques);
                PerderVida(ataques);
            }
            else {
                ataques = aleatorio.Next(aliado.vida / 2, aliado.vida);
                aliado.PerderVida(ataques);
                DistribuirExp(ataques);
            }

            return ataques.ToString();
        }

        public void RecuperarMana(int stamina) {
            this._mana += stamina;
        }

        public void PerderMana(int stamina) {
            this._mana -= stamina;
        }

        public void RecuperarVida(int cura) {
            this._vida += cura;

            vidaTotal += cura;
        }

        public void PerderVida(int dano) {
            this._vida -= dano;

            vidaTotal -= dano;
        }

        public void DistribuirExp(int experiencia) {
            this._xp += experiencia;
        }

        static public string Help(){
            return "Lute para ganhar XP\nCure para ganhar Vida\nMedite para ganhar Mana.";
        }
    }
}
