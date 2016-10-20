using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class BinarySearch
    {
        public static int Search(int[] array, int x)
        {
            int index = -1;
            if (array != null)
            {

                int left = 0;
                int right = array.Length;

                while (left < right)
                {
                    int middle = (left + right) / 2;

                    if (array[middle] == x)
                    {
                        index = middle;
                        break;

                    }
                    else
                    {
                        if (array[middle] > x)
                        {
                            right = middle;
                        }
                        else
                        {

                            left = middle + 1;


                        }
                    }


                }
            }

            Console.WriteLine(x + " " + index);
            return index;

        }
    }
}
