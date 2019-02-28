using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1{
    class Conta{
        double saldo{ get; set; }

        public void Debitar(double valor){
            this.saldo += valor;
        }
        public void Creditar(double valor){
            this.saldo -= valor;
        }
        public double VerSaldo(){
            return saldo;
        }
    }
}
