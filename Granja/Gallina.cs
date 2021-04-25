using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    public class Gallina : IAveCorrerGraznar
    {
        public string Correr()
        {
            var correr = "estoy corriendo soy una gallina";
            return correr;
        }

        public string Graznar()
        {
            var graznar = "estoy graznando soy una gallina";
            return graznar;
        }
    }
}
