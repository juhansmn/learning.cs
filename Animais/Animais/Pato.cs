using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Pato : Animal, IOviparo
    {
        public void BotarOvo()
        {
            System.Windows.Forms.MessageBox.Show("Botou o ovo.");
        }
    }
}
