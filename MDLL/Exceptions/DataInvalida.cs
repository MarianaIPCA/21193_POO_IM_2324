using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDLL.Exceptions
{
    public class DataInvalida: ApplicationException
    {
            public DataInvalida() : base("Data Inválida")
            {
            }

            public DataInvalida(string s) : base(s) { }

            public DataInvalida(string s, Exception e)
            {
                //throw new Exception(e.Message + " - " + s);
                throw new DataInvalida(e.Message + " - " + s);
            }

    }
}
