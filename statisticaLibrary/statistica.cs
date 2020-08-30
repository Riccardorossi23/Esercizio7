using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statisticaLibrary
{
    public class statistica
    {
        public static bool IsPositivo(int n)
        {
            bool valore;
            if (n > 0)
            {
                valore = true;
            }
            else
            {
                valore = false;
            }

            return valore;
        }
        public static int ContaPositivi(int[] array)
        {
            int valore = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    valore++;
                }

            }
            return valore;
        }

        public static int[] Positivi(int[] array)
        {
            List<int> Positivi = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    Positivi.Add(array[i]);
                }

            }
            int[] valore = new int[Positivi.Count];

            for (int i = 0; i < valore.Length; i++)
            {
                valore[i] = Positivi[i];
            }
            return valore;
        }
    }
}
