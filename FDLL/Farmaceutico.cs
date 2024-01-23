using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FDLL;

namespace MDLL
{
    public class Farmaceutico : Pessoa
    {
        #region Atributos
        /// <summary>
        /// Um atributo que representa a associação do farmacêutico com uma instância da classe Farmacia.
        /// </summary>
        Farmacia farmacia;

        #endregion

        #region Metodos

        #region Construtores
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        /// <param name="farmacia"></param>
        public Farmaceutico(string nome, Farmacia farmacia)
        {
            this.Nome = nome;
            this.farmacia = farmacia;
        }

        #endregion

        #region Propriedades 

        /// <summary>
        /// Como já existe uma classe chamada Farmacia, dá-mos o nome de '_Farmacia', facilita o acesso à variável pretendida
        /// Utilizada na função de remover medicamento apartir da classe Farmaceutico
        /// Uma propriedade que permite acessar e modificar a instância da classe Farmacia associada ao farmacêutico.
        /// </summary>
        public Farmacia _Farmacia
        {
            get { return farmacia; }
            set { farmacia = value; }
        }

        #endregion

        #region Outros métodos

        #endregion

        #endregion

    }
}