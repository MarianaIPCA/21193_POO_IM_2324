using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FDLL;
using MDLL;

namespace FRDLL
{
    public class Regras
    {
        /// <summary>
        /// Regra- só pode adicionar todos os tipos de medicamentos exceto tipo de analgesico (exemplo)
        /// </summary>
        /// <param name="m"></param>
        /// <param name="f"></param>
        /// <returns></returns>
        public static bool InserirMedicamentoErrado(Medicamento m)
        {
            if (m.TipoMed != TipoMedicamentos.Analgesico)   // Regra de negócio
            {
                Farmacia.InserirMedicamento(m);
                return true;
            }
            return false;
        }

        public static bool InsereMedicamento(Medicamento m)
        {
           if (m.NomeMedicamento==null) {

                return false;
           }
            Farmacia.InserirMedicamento(m);//Inserir
            return true;
           
        }
        



    }
}
