using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Galinha : Animal, IOviparo
    {
        public void BotarOvo()
        {
            System.Windows.Forms.MessageBox.Show("Botou os ovos.");
        }
    }
}
