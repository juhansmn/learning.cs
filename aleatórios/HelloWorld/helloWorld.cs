using System;

namespace helloWorld{
    class Hello{
        static void Main(){
            Console.WriteLine("Hello World!");

            var valor = Convert.ToInt32(Console.ReadLine());
            Calculadora objeto = new Calculadora();
            Console.WriteLine("{0} + 3 = {1}", valor, objeto.Soma(valor, 3));
            Console.ReadKey();

            Pessoa ser = new Pessoa("Carlos Cucko");
            Console.WriteLine("Nome: {0}", ser.Nome);

            Pessoa ser2 = new Pessoa("");
            Console.WriteLine("Nome: {0}", ser2.Nome);
            
        }
    }
    class Calculadora{
        int soma1 = 2;
        public int Soma(int soma1, int soma2){
            return (this.soma1 = soma1) + soma2;
        }
    }

    class Pessoa{
        private string nome = "Desconhecido";
        public Pessoa (string nome){
            if (nome != "")
                this.nome = nome;
        }

        public string Nome{
            get{
                return nome;
            }
            private set{
                nome = value;
            }
        }
    }
}