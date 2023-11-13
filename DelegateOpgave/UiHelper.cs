using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOpgave
{
    internal class UiHelper
    {

            public void ReturnNumbers(int number, RefToPrint print)
            {

                List<int> result = new List<int>();

                for (int i = 0; i <= number; i++)
                {
                    result.Add(i);
                }

                bool isEven = false;

                if (number % 2 == 0)
                {
                    isEven = true;
                }

                if (isEven)
                {
                    result = result.Where(n => n % 2 == 0).ToList();
                }
                else
                {
                    result = result.Where(n => n % 2 != 0).ToList();
                }

                print(result);

            }

    }
}
