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
        /// <summary>
        /// Exemplo de implementação
        /// </summary>
        public static void Main()
        {
            CriarInstanciaFarmacia();
            Medicamento m = new Medicamento();  


            Regras.InsereMedicamento(m);
        }

        public static Farmacia CriarInstanciaFarmacia()
        {
            Farmacia farmacia = new Farmacia("Farmacia1");
            return farmacia;    
        }

    }
}
