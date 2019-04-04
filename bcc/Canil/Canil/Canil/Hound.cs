using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Canil {
    class Hound {
        [DisplayName("Nome")]
        public string nome { get; set; }

        [DisplayName("Data de Nascimento")]
        public string dataNascimento { get; set; }

        public bool pedigree = false;

    }
}
