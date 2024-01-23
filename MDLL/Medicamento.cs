using System;
using System.Collections.Generic;

using MDLL.Exceptions;
public enum TipoMedicamentos
{
    Analgesico,
    Antibiotico,
    AntiInflamatorio,
    AntiHistaminico

}
namespace MDLL
{
    [Serializable]
    
    public class Medicamento : IComparable<Medicamento>
    {
        #region Atributos

        private string nome;
        private TipoMedicamentos tipo;
        private DateTime dataValidade;

        #endregion

        #region Metodos

        #region Construtores
        public Medicamento(string nomeMed, TipoMedicamentos t, string dv)
        {
            this.nome = nomeMed;
            tipo = t;
            try
            {
                dataValidade = DateTime.Parse(dv);
            }
            catch(Exception e) 
            {
                throw new DataInvalida("Formato inválido.", e);
            }   
        }

        //pré definição do medicamento ao ser criado
        public Medicamento()
        {
            nome = "";
            tipo= TipoMedicamentos.Analgesico;
            dataValidade= DateTime.Today;
        }

        #endregion

        #region Propriedades
        public string NomeMedicamento
        {
            set { nome = value; }
            get { return nome; }
        }

        public TipoMedicamentos TipoMed
        {
            set { tipo = value; }
            get { return tipo; }
        }
        public DateTime DataValidade
        {
            set { dataValidade = value; }
            get { return dataValidade; }
        }
        #endregion

        #region Overrides
        //neste caso, o que faz é representar uma string formatada para apresentar o medicamento, que retorna os respectivos dados*/
        public override string ToString()
        {
            return ("-> Nome: " + this.nome + " - Tipo: " + this.tipo.ToString() + " - Data de Validade: " + this.DataValidade.ToString("dd/MM/yyyy"));
        }

        #endregion

        #region Outros Metodos

        public int CompareTo(Medicamento m)
        {
            return 1;

        }

        public static DateTime NovaData(string d)
        {
            try
            {
                return (DateTime.Parse(d));
            }
            catch (Exception e)
            {
                throw new DataInvalida("Data invalida.", e);
            }
        }
        #endregion

        #endregion
    }
}
