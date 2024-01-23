using MDLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Principal;

namespace FDLL
{

    
    public class Farmacia: IFarmacia
    {
        #region Atributos
        private string nome;
        private static List<Medicamento> medicamentos;

        Dictionary<TipoMedicamentos, List<Medicamento>> x;


        private string filePath = "dadosfarmacia.bin"; 
        #endregion

        #region Metodos

        #region Construtores
        static Farmacia()
        {
            medicamentos = new List<Medicamento>();
        }

        public Farmacia(string nome)
        {
            this.nome = nome;
            medicamentos = new List<Medicamento>();
        }

        #endregion

        #region Propriedades
        public string NomeFarmacia
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion

        #region Outros Metodos
        /// <summary>
        /// Inserir medicamento 
        /// </summary>
        /// <param name="medicamento"></param>
        /// <returns></returns>
        public static bool InserirMedicamento(Medicamento medicamento)
        {
            if (medicamento == null) 
            { 
                return false; 
            }
            if (medicamentos.Contains(medicamento))
            {
                return false;
            }
            medicamentos.Add(medicamento);
            return true;          
        }

        /// <summary>
        /// Mostrar medicamento
        /// </summary>
        /// <returns></returns>
        public static bool MostrarMedicamentos()
        {
            if (medicamentos.Count == 0)
            {
                //Nenhum medicamento encontrado.
                return false;
            }
            else
            {
                foreach (Medicamento med in medicamentos)
                {
                    Console.WriteLine(med);
                }

            }
            return false;
        }

        /// <summary>
        /// Remover medicamento
        /// </summary>
        /// <param name="medicamento"></param>
        /// <returns></returns>

        public static bool RemoverMedicamento(Medicamento medicamento)
        {
            if (medicamento == null)
            {
                return false;
            }
            medicamentos.Remove(medicamento);
            return true;

        }

        /// <summary>
        /// Guardar medicamentos em binário 
        /// </summary>
        /// <param name="filePath"></param>
        //Guardar medicamentos em ficheiro binário
        static void GuardarMedicamentos(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    formatter.Serialize(fs, medicamentos);
                }

                Console.WriteLine("Dados guardados com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
        }

        /// <summary>
        /// Ler medicamentos guardados em ficheiro binário
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        static Farmacia LerMedicamentosGuardados(string filePath)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    Farmacia deserializedObject = (Farmacia)formatter.Deserialize(fs);
                    return deserializedObject;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
                return null;
            }
        }

        #endregion
        


        #endregion
    }
}
