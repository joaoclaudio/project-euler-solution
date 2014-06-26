using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_solution
{
    public class MultiplesOfThreeAndFive
    {
        private int SomaDosMutiplos(int razao, int limite)
        {
            return razao * (limite / razao) * ((limite / razao) + 1) / 2;
        }
        public int solucionarMatematica()
        {
            return SomaDosMutiplos(3, 999) + SomaDosMutiplos(5, 999) - SomaDosMutiplos(15, 999);
        }

        public int solucionarLoop1()
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    sum += i;
                }
            }
            return sum;
        }

        public int solucionarLoop2()
        {
            int sum = 0;

            for (int i = 3; i < 1000; i += 3)
                sum += i;

            for (int i = 5; i < 1000; i += 5)
                sum += i;

            for (int i = 15; i < 1000; i += 15)
                sum -= i;

            return sum;
        }

        public int solucionarLoop3()
        {
            int sum = 0;

            for (int i = 3; i < 1000; i += 3)
                sum += i;

            for (int i = 5; i < 1000; i += 5)
            {
                if (i % 3 != 0)
                    sum += i;
            }

            return sum;
        }
    }
}
