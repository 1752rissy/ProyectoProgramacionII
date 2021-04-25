using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Pato : Animal
    {
        public override string Correr()
        {
            string correr = "Estoy corriendo soy un pato";
            return correr;
        }

        public override string Graznar()
        {
            throw new NotImplementedException();
        }

        public override bool Jugar()
        {
            throw new NotImplementedException();
        }

        public override string Nadar()
        {
            throw new NotImplementedException();
        }

        public override string Volar()
        {
            throw new NotImplementedException();
        }
    }
}
