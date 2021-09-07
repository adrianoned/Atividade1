using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    public class Utilitario
    {
        public void calcularSeguencia()
        {
            long qtdVezes;
            long qtdVezesMaior = 0;
            long numeroIncial = 0;
            for (long i = 1; i <= 1000000; i++)
            {
                qtdVezes = 0;

                for (long j = i; j > 1;)
                {
                    if (j % 2 == 0)
                        j = (j / 2);
                    else
                        j = (3 * j + 1);

                    qtdVezes++;
                }

                if(qtdVezesMaior < qtdVezes)
                {
                    qtdVezesMaior = qtdVezes;
                    numeroIncial = i;
                    
                }
                
            }

            Console.WriteLine($"A maior sequencia e iniciada pelo numero {numeroIncial} e efetuou {qtdVezesMaior} de iterações");
        }

       


        public bool verificaNumerosImpares(int [] numeros)
        {
            return !(numeros.Where(obj => obj % 2 == 0).Any()) ;
        }

        public void comparaArray()
        {
            int[] primeiroArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] segundoArray = { 4, 6, 93, 7, 55, 32, 3 };

            List<int> lst = new List<int>();
            lst.AddRange(primeiroArray.Where(obj => !segundoArray.Contains(obj)));

            Console.WriteLine($"Numeros que não estão contidos no segundo Array: {string.Join(",", lst.ToArray())}");
        }

    }

    
}
