using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Utilitario obj = new Utilitario();

            #region Exercicio1_1
            obj.calcularSeguencia();
            #endregion

            #region Exercicio1_2
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            //int[] numeros = { 1, 3, 5, 9, 13, 21, 35, 55, 89, 145 };
            if (obj.verificaNumerosImpares(numeros))
            {
                Console.WriteLine("O Array possui apenas números impares!");
            }
            else
                Console.WriteLine("O Array possui números pares!");
            #endregion

            #region Execicio1_3
            obj.comparaArray();
            #endregion
            
        }
    }
}
