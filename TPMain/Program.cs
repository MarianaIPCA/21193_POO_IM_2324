using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FDLL;
using FRDLL;
using MDLL;

namespace TPMain
{
    public class Program
    {
        public static void Main()
        {
            CriarInstanciaFarmacia();
        }

        public static Farmacia CriarInstanciaFarmacia()
        {
            Farmacia farmacia = new Farmacia("Farmacia1");
            return farmacia;    
        }

    }
}
