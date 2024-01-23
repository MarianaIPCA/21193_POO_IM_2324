using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDLL
{
    public class Pessoa
    {
        #region Atributos

        private string nome;
        #endregion

        #region Metodos

        #region Construtores

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public Pessoa()
        {
            this.nome = "Não atribuído";
        }

        #endregion

        #region Propriedades

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion

        #endregion
    }
}
