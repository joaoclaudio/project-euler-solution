using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_solution
{
    public class MultiplesOfThreeAndFive
    {
        private int SomaDosMutiplos(int razao, int limite){
            return razao * (limite / razao) * ((limite / razao) + 1) / 2;
        }
        public int solucionar()
        {
            return SomaDosMutiplos(3,999)+
                SomaDosMutiplos(5,999)-
                SomaDosMutiplos(15,999);
        }
    }
}
